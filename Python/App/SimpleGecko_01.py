PASS = 'AUMJ88'

VERSION = 'BATE'
INFORMATION = '''
Simple Gecko
Author   | IsNot
Youtube  | Unknown
'''

DEBUG_MODE = 'off'
#on/off
#バグ修正やアプリケーションのテストで使用
#WiiU本体が無くてもアプリケーションを起動できます。
#IP入力画面にてdと入力することでもデバッグモード起動可能

ENCODING = 'utf-8'
#エンコード方法
#☆変更非推奨

#_______ ここから下は触らない _______#

from time import sleep
from pathlib import Path
from platform import platform
from datetime import datetime

import os
import sys
import glob
import time
import math
import socket
import pathlib
import binascii
from xml.etree import ElementTree
import xml.etree.ElementTree as ET

def clear():  print ('\n'*77 )

def enter() -> None:  input ('エンターで終了>>>')

def tree(path, layer=0, is_last=False, indent_current=' '):
    if not pathlib.Path(path).is_absolute():
        path = str(pathlib.Path(path).resolve())
        
    current = path.split('/')[::-1][0]
    if layer == 0:
        print('<'+current+'>')
    else:
        branch = '└' if is_last else '├'
        print('{indent}{branch}<{dirname}>'.format(indent=indent_current, branch=branch, dirname=current))

    paths = [p for p in glob.glob(path+'/*') if os.path.isdir(p) or os.path.isfile(p)]
    def is_last_path(i):
        return i == len(paths)-1

    for i, p in enumerate(paths):

        indent_lower = indent_current
        if layer != 0:
            indent_lower += '  ' if is_last else '│ '

        if os.path.isfile(p):
            branch = '└' if is_last_path(i) else '├'
            print('{indent}{branch}{filename}'.format(indent=indent_lower, branch=branch, filename=p.split('/')[::-1][0]))
        if os.path.isdir(p):
            tree(p, layer=layer+1, is_last=is_last_path(i), indent_current=indent_lower)
            
XMLCODE_NAME      = []
XMLCODE_CODE      = []
XMLCODE_ASM       = []
XMLCODE_ENABLED   = []
ONCODE_ASM        = []
ONCODE_CAFE       = []
ONCODE_NAME       = []
SELECTED_CMD_LIST = []
UNLOCK_KERNEL     = []
asm = ''
cafe = ''

def openfile() -> None:
    with open(PASS+'.xml', mode='rt', encoding=ENCODING) as f:
        xml_string = f.read().replace('\u3000','')

    root = ET.fromstring(xml_string)
    for name in root.iter('code'):
        ADD_CODE = (name.text)
        XMLCODE_CODE.append(ADD_CODE)
        
    for name in root.iter('assembly_ram_write'):
        ADD_ASM = (name.text)
        XMLCODE_ASM.append(ADD_ASM)
        
    for name in root.iter('enabled'):
        ADD_ENA = str(name.text).replace('false',' ').replace('true','✓')
        XMLCODE_ENABLED.append(ADD_ENA)
        
    for child in root:
        z = (child.attrib["name"])
        XMLCODE_NAME.append(z)
        
    b = 0
    for i in XMLCODE_NAME:
        a = XMLCODE_NAME[b]
        d = XMLCODE_ENABLED[b]
        b = b+1
        if d == '✓':
            TARGET_CODE = XMLCODE_CODE[b-1]
            TARGET_ASM = XMLCODE_ASM[b-1]
            TARGET_NAME = XMLCODE_NAME[b-1]
            if TARGET_ASM == 'true':  ONCODE_ASM.append(TARGET_CODE)
            else:  ONCODE_CAFE.append(TARGET_CODE)
            ONCODE_NAME.append(TARGET_NAME)
            
    with open(PASS+'.xml', encoding=ENCODING) as f:
        lines = f.readlines()
        lines_strip = [line.strip() for line in lines]
        for i in lines_strip:
            if i.startswith('#'):
                i = i.replace('#','').replace('\n','').replace(' ','')
                UNLOCK_KERNEL.append(i)
        for ia in lines_strip:
            if ia.startswith('<code>#'):
                ia = ia.replace('<code>#','').replace('\n','').replace(' ','')
                UNLOCK_KERNEL.append(ia)
                
DRAW_HELP_MAIN = {
    '1    ':'コードのON/OFF情報の送信',
    '?h   ':'ヘルプ',
    '?l   ':'コードのon/off管理',
    '?task':'端末情報',
    '?e   ':'アプリケーションを終了',
}
LOCAL_IP = 'None'
#Start Gecko
clear()
print ('Loading-Application...')
openfile()
KERNEL_UNLOCK_MAIN = ''.join(s for s in UNLOCK_KERNEL)
clear()#気が向いたらきれいにするZE☆
if DEBUG_MODE == 'on':  DEBUG_MARK = '⚙'
elif DEBUG_MODE == 'off':
    INP_LOCAL_IP = input ('IP: 192.168.')
    LOCAL_IP = '192.168.'+INP_LOCAL_IP
    if INP_LOCAL_IP == 'd':  DEBUG_MARK = '⚙'
    else:
        DEBUG_MARK = ''
        ip = LOCAL_IP
        Connect = binascii.unhexlify('7072696e7428275c6e2020e68ea5e7b69ae4b8ade381a7e381995c6e27290d0a7072696e742827e38182e381aae3819fe3818ce8a8ade5ae9ae38197e3819f4950e382a2e38389e383ace382b9203a2020272b6970290d0a733d736f636b65742e736f636b657428736f636b65742e41465f494e45542c736f636b65742e534f434b5f53545245414d290d0a732e636f6e6e656374282869702c3733333129290d0a732e73656e642862797465732e66726f6d686578282730332729290d0a732e73656e642862797465732e66726f6d6865782827313030313443464330303030303030302729290d0a0d0a666f72207820696e2072616e6765286d6174682e666c6f6f72286c656e2863616665292f3829293a0d0a20202020732e73656e642862797465732e66726f6d686578282730332729290d0a20202020732e73656e642862797465732e66726f6d686578282730272b666f726d617428307830313133333030302b78342c275827292b636166655b78383a78382b385d29290d0a732e73656e642862797465732e66726f6d686578282730332729290d0a732e73656e642862797465732e66726f6d6865782827313030313443464330303030303030312729290d0a0d0a666f72207820696e2072616e6765286d6174682e666c6f6f72286c656e2861736d292f313629293a0d0a20202020732e73656e642862797465732e66726f6d686578282730332729290d0a20202020732e73656e642862797465732e66726f6d6865782861736d5b7831363a782a31362b31365d29290d0a732e636c6f736528290d0a7072696e7428275c6ee68ea5e7b69ae38197e381bee38197e3819f2729').decode(ENCODING)
        try:  exec (Connect)
        except:  input ('接続できませんでした');sys.exit()
else:  input ('モード設定が不正です。アプリケーションを終了します。');sys.exit()
#COMMAND
def COM_qH() -> None:
    for k, v in DRAW_HELP_MAIN.items():
        print (k+': '+ v)
    enter()
    
def MSbyUnknown() -> None:
    if None == None:  pass
    elif None == None:  pass
    if None == None:  pass
    elif None == None:  pass
    elif None == None:  pass
    if None == None:  pass
    elif None == None:  pass
    if None == None:  pass

def COM_qL() -> None:
    while True:
        clear()
        b = 0
        for i in XMLCODE_NAME:
            a = XMLCODE_NAME[b]
            d = XMLCODE_ENABLED[b]
            b = b+1
            print (f'{b}|{d}|{a}')
             
        print ('bで終了\nAdd/Remuve')
        SELECTED_CMD = input ('└>SELECT-CODE: ')
        try:
            SELECTED_CMD_LIST = SELECTED_CMD.split()
            v = 0
            for i in SELECTED_CMD_LIST:
                SELECTED_CMD = SELECTED_CMD_LIST[v]
                SELECTED_CMD = int(SELECTED_CMD)-1
                TARGET_CODE = XMLCODE_CODE[SELECTED_CMD]
                TARGET_ASM = XMLCODE_ASM[SELECTED_CMD]
                TARGET_NAME = XMLCODE_NAME[SELECTED_CMD]
                JUDGE_NAME = TARGET_NAME in ONCODE_NAME
                if JUDGE_NAME == True:
                    ONCODE_NAME.remove(TARGET_NAME)
                    if TARGET_ASM == 'true':  ONCODE_ASM.remove(TARGET_CODE)
                    else:  ONCODE_CAFE.remove(TARGET_CODE)
                    XMLCODE_ENABLED[SELECTED_CMD] = ' '
                
                else:
                    ONCODE_NAME.append(TARGET_NAME)
                    if TARGET_ASM == 'true':  ONCODE_ASM.append(TARGET_CODE)
                    else:  ONCODE_CAFE.append(TARGET_CODE)
                    XMLCODE_ENABLED[SELECTED_CMD] = '✓'
                v = v+1
            SELECTED_CMD_LIST.clear()
        except:
            if SELECTED_CMD == 'b':  break
            else:  input ('数字を間違えています')

def COM_1() -> None:
    sel = 0
    cu = 0
    asm_in_unlock = ''.join(s for s in ONCODE_ASM)
    asm = asm_in_unlock.split('\n')
    asm = [s for s in asm if '#' not in s]
    asm = ''.join(s for s in asm).replace(' ','')
    cafe = ''.join(s for s in ONCODE_CAFE).replace(' ','').replace('\n','')
    print ('┐')
    '''
    print('\n  接続中です\n')
print('あなたが設定したIPアドレス :  '+ip)
'''
    def SEND_CODE() -> None:
        ip = LOCAL_IP
        try:
            unsend = binascii.unhexlify(b'7072696e7428275c6e2020e68ea5e7b69ae4b8ade381a7e381995c6e27290d0a7072696e742827e38182e381aae3819fe3818ce8a8ade5ae9ae38197e3819f4950e382a2e38389e383ace382b9203a2020272b6970290d0a0d0a733d736f636b65742e736f636b657428736f636b65742e41465f494e45542c736f636b65742e534f434b5f53545245414d290d0a732e636f6e6e656374282869702c3733333129290d0a732e73656e642862797465732e66726f6d686578282730332729290d0a732e73656e642862797465732e66726f6d6865782827313030313443464330303030303030302729290d0a0d0a666f72207820696e2072616e6765286d6174682e666c6f6f72286c656e2863616665292f3829293a0d0a20202020732e73656e642862797465732e66726f6d686578282730332729290d0a20202020732e73656e642862797465732e66726f6d686578282730272b666f726d617428307830313133333030302b78342c275827292b636166655b78383a78382b385d29290d0a732e73656e642862797465732e66726f6d686578282730332729290d0a732e73656e642862797465732e66726f6d6865782827313030313443464330303030303030312729290d0a0d0a666f72207820696e2072616e6765286d6174682e666c6f6f72286c656e284b45524e454c5f554e4c4f434b5f4d41494e292f313629293a0d0a20202020732e73656e642862797465732e66726f6d686578282730332729290d0a20202020732e73656e642862797465732e66726f6d686578284b45524e454c5f554e4c4f434b5f4d41494e5b7831363a782a31362b31365d29290d0a732e636c6f73652829').decode(ENCODING)
            send = binascii.unhexlify(b'733d736f636b65742e736f636b657428736f636b65742e41465f494e45542c736f636b65742e534f434b5f53545245414d290d0a732e636f6e6e656374282869702c3733333129290d0a732e73656e642862797465732e66726f6d686578282730332729290d0a732e73656e642862797465732e66726f6d6865782827313030313443464330303030303030302729290d0a0d0a666f72207820696e2072616e6765286d6174682e666c6f6f72286c656e2863616665292f3829293a0d0a20202020732e73656e642862797465732e66726f6d686578282730332729290d0a20202020732e73656e642862797465732e66726f6d686578282730272b666f726d617428307830313133333030302b78342c275827292b636166655b78383a78382b385d29290d0a732e73656e642862797465732e66726f6d686578282730332729290d0a732e73656e642862797465732e66726f6d6865782827313030313443464330303030303030312729290d0a0d0a666f72207820696e2072616e6765286d6174682e666c6f6f72286c656e2861736d292f313629293a0d0a20202020732e73656e642862797465732e66726f6d686578282730332729290d0a20202020732e73656e642862797465732e66726f6d6865782861736d5b7831363a782a31362b31365d29290d0a732e636c6f736528290d0a7072696e7428275c6ee382b3e383bce38389e38292e98081e4bfa1e38197e381bee38197e3819f2729').decode(ENCODING)
            #print (cafe)
            #print (asm)
            #print (KERNEL_UNLOCK_MAIN)
            exec (unsend)
            exec (send)
        except:  input ('WiiUとの接続中にエラーが発生しました')
    for i in ONCODE_NAME:
        print (f'│{ONCODE_NAME[cu]}')
        sel = 1
        cu = cu+1
    if sel == 0:
        print ('│None')
        print ('┘')
        input ('コードが選択されていません')
    else:
        print ('┘')
        input ('上記のコードを送信、他を解除します')
        if DEBUG_MARK == '⚙':
            input ('デバッグモードの為コードを送信しませんでした')
        else:
            SEND_CODE()
def Draw_main_menu() -> None:
    while True:
        clear();MAIN_COMMAND_INP = input (f'{PASS}\n└>{DEBUG_MARK}|Simple Gecko Menu: ') 
        if MAIN_COMMAND_INP == '?e':  print ('ThankYou!');break
        elif MAIN_COMMAND_INP == '1': COM_1()
        elif MAIN_COMMAND_INP == '?h':  COM_qH()
        elif MAIN_COMMAND_INP == '?l':  COM_qL()
        elif MAIN_COMMAND_INP == '?task':
            clear()
            tree('./');enter()
        
Draw_main_menu()
