AppINFO = "SimpleGecko"
Version = 3.0
creator  = "Anti_Virus"
""""""

ipadr ='192.168.11.9'
#ipアドレス 入力必須

On_mark = "▪"
# お好みで)ONになっているコードに付くマーク[ 自由 ]
Sort_reverse = True
# お好みで)コードの並び順の反転[ True / False ]
Auto_save = 4
# お好みで)1以上にすると指定された回数コードリストに変更があれば自動でセーブ[ 0だとオートセーブがOFFになる ]
Draw_MiniMenu = True
# お好みで)コード管理画面下部のミニメニュー(Sort,Activeなど)を表示するか[ True / False ]
Draw_LocalIPs = True
# お好みで)ローカルIP検索時に接続を拒否されたipたちを表示するか[ True / False ]

Mainlist_name = "v3.0Codes" # Xml-nico57.xml
# 変更非推奨)デフォルトのコードリスト名[ 自由 ]
Xmlslist_name = "v3.0Xml-"
# 変更非推奨)Xml→コードリスト変換時に作られるファイル名の先頭の文字[ 自由 ]
Encoding = "utf-8"
# 変更非推奨)エンコード形式[ utf-8 / cp932 ] 
Delimiter = ":"
# 変更非推奨)コードリストの区切り文字[ 自由 ]
Colorcs_list=["白","緑","赤","青","桃","橙","黄","水"]
# 変更非推奨)グローバルIP特定時のカラーリスト[ 自由 ]
option = "ip"
# 変更非推奨)グローバルIP特定時のip出力方法[ hex / ip ]

Connect_to = 7331
# 変更禁止)接続時に使用
Cafe_from = ['10014CFC00000001','10014CFC00000000']
# 変更禁止)コード送信時に使用
address_forCafe = 0x01133000
# 変更禁止)カフェコードの保管先
""""""

# ----- ここから下メインプログラム ----- #

import os
import sys
import glob
import time
import binascii
import socket,struct
import urllib.request
import xml.etree.ElementTree as ET
import math

from time import sleep
from platform import platform


def clear() -> None:
    print ('\n'*77)
    os_name = platform()
    if "Windows" in os_name: os.system("cls")
    elif "macOS" in os_name or "Linux" in os_name: os.system("clear")
clear();print ('lading application...')
def enter() -> None:  input ("エンターで終了\n")
try:
    AutoSave_count = "None" if Auto_save == 0 else Auto_save
    try:
        _ = int(AutoSave_count)
        if _ < 0:
            AutoSave_count = "None"
    except:
        AutoSave_count = "None"
except:  AutoSave_count = "None"
def help_command() -> None:
    print ("✼••┈Help!┈••✼")
    print ("""SimpleGecko v3.0\n             by Nico57
           
?h  |  操作方法-help
?l  |  コードのON/OFF管理-CodeManager
?x  |  xml→コードリスト変換-Convert
1   |  コード送信-SendCode
?n  |  NNID変更コード作成-Change NNID
?e  |  アプリケーションを終了-exit
""");enter()
try:
    with open ("v3.0Setting.ini","r") as f:
        J_import__ = False
except:
    clear();print ("初回セットアップ中")
    J_import__ = True
    with open ("v3.0Setting.ini","w",encoding=Encoding) as f:
        f.write(f"[Setting]\nConfig = False\nOn_mark = {On_mark}\nSort_reverse = {Sort_reverse}\nAuto_save = {Auto_save}\nDraw_MiniMenu = {Draw_MiniMenu}\nDraw_LocalIPs = {Draw_LocalIPs}")
def createList(s,n):
    lst = []
    n = n+1
    for i in range(n-s):
        lst.append(s)
        s = s+1
    return(lst)
def formatCode(from_code):
    form = " ".join([from_code[i:i+8] for i in range(0,len(from_code),8)])
    result = "\n".join([form[i:i+18] for i in range(0,len(form),18)]).replace(" \n","\n")
    return result
def Save_list(unlock_codes,code_name,readcode,Onlist, Mainlist_name):
    unlocks = []
    with open (Mainlist_name,"w", encoding=Encoding) as f:
        for i in code_name:
            try:  unlocks.append(unlock_codes[i])
            except:  unlocks.append("@")
        re = "$".join(unlocks)
        # input (re)
        unlock__ = re.split("$")
    #    print (unlock__)
        for x,i in enumerate(code_name):
            add_code = readcode[i]
            add_unlock = unlock__[x]
            if add_unlock == " ":
                add_unlock = ""
            add_unlock = add_unlock.replace("@","").replace("#","\n#")
            f.write(i)
            if i in Onlist:
                f.write("\non")
            else:
                f.write("\noff")
            f.write(add_unlock+"\n"+add_code+"\n"+Delimiter+"\n")
class open_list:
    def open(self,Mainlist_name):
        while True:
            try:
                with open(Mainlist_name,mode = "r",encoding = Encoding) as f:
                    codes_list = f.readlines()
                    codes_list = [line.rstrip("\n") for line in codes_list if not line == "\n"]
                    # input (codes_list)
                    break
            except:
                with open(Mainlist_name,mode = "w",encoding = Encoding) as f:
                    f.write(f'''fly
on
#0271AA74 7FE3FB78
0271AA74 38600001
{Delimiter}
パケット弓連射
off
C0000017 60000000
9421FFF0 7C0802A6
90010014 92810018
3E80109D 82949BF0
8294034C 2C140000
41820070 3E80109D
8294D8E4 82940034
2C140000 4182005C
38600000 38800005
38A10030 3CC0109C
80C646A0 81940054
91850000 81940058
91850004 8194005C
91850008 3D80028A
618CEC5C 7D8903A6
4E800421 38810020
90610020 80740878
3D800304 618CA5D8
7D8903A6 4E800421
80010014 82810018
7C0803A6 38210010
3C40010F 60426AE0
7C4903A6 4E800420
{Delimiter}''')
        return codes_list
    def read(self,result_names,result_codes,result_enabs,result_asmws):
        self.result_names = result_names
        Code__ = {}
        Enab__ = []
        Asmw__ = {}
        Onlist = []
        for x,i in enumerate(result_names):
            Code__[i] = result_codes[x]
            if result_enabs[x] == 'on':
                Onlist.append(i)
            Asmw__[i] = result_asmws[x]
        return Code__,Asmw__,Onlist
def kata_to_hira(strj):
    return "".join([chr(ord(ch) - 96) if ("ァ" <= ch <= "ヴ") else ch for ch in strj])
def Search_ip() -> str:
    print ("検索中です...")
    firstCount = 0
    subCount = 0
    
    while True:
        s=socket.socket(socket.AF_INET,socket.SOCK_STREAM)
        s.settimeout(0.02)
        firstCount += 1
        if(firstCount > 150):
            firstCount  = 0
            subCount  += 1
            
        ip = f'192.168.{subCount}.{firstCount}'
        try:
            s.connect((ip,7331))
            print(f'\n接続しました:{ip}');time.sleep(1)
            break
        except:
            if Draw_LocalIPs:  print(f'接続不可:{ip}')
            else:  pass
        s.close()
    return ip
if J_import__:
    try:  import requests
    except:  os.system("pip install requests");import requests
def Code_Manager(code_name, Onlist, readcode, unlock_codes, AutoSave_count, read_code, read_asmw, Mainlist_name):
    while True:
        clear()
        delete_mode = False
        copy_mode = False
        print ("✼••┈Codes!┈••✼")
        code_range = len(code_name)
        result_range = len(str(code_range))
        if AutoSave_count == 0:
            Save_list(unlock_codes,code_name,readcode,Onlist, Mainlist_name)
            AutoSave_count = Auto_save
        print ("▪┐".rjust(result_range+1))
        y = -1
        range_rev = len(code_name)
        for x,i in enumerate(code_name):
            if Sort_reverse:
                g = code_name[y]
                of = On_mark if g in Onlist else " "
                print (f"{str(range_rev).rjust(result_range)}|{of}├{g}")
                y -= 1
                range_rev -= 1
            else:  of = On_mark if i in Onlist else " ";print (f"{str(x+1).rjust(result_range)}|{of}├{i}")
        print ("▪┘".rjust(result_range+1))
        DrawSort = "ON" if Sort_reverse else "OFF"
        if Draw_MiniMenu:  print (f"Sort reverse[{DrawSort}]\nAutoSave: {AutoSave_count}\nActive: {len(Onlist)}")
        Selected = input ("┌Switch Code[エンターでホームへ]\n└Number->")
        if Selected == "":
            break
        elif Selected == "s":
            answer = input ("本当にセーブしますか?\nyでセーブスタート、他はキャンセル\n>>>")
            if answer == "y":
                clear()
                Save_list(unlock_codes,code_name,readcode,Onlist, Mainlist_name)
                print ("✓ セーブしました");time.sleep(1)
            else:
                clear()
                print ("キャンセル");time.sleep(0.5)
        else:
            try:
                if Selected.startswith('?'):
                    Selected = Selected.lower().replace("?","").replace(" ","")
                    SearchedWord = kata_to_hira(Selected)
                    print ("\n---検索結果---")
                    c = False
                    for x,result in enumerate(code_name):
                        Target_search = result.lower().replace(" ","")
                        Target_search = kata_to_hira(Target_search)
                        if SearchedWord in Target_search:
                            print (f"{x+1}|{result}")
                            c = True
                    if not c:  print ('見つかりませんでした:(')
                    enter()
                elif Selected.startswith('!'):
                    clear()
                    AddName_No = Selected.replace("!","")
                    AddName = AddName_No
                    l = 2
                    while True:
                        if AddName in code_name:
                            AddName = AddName_No+"("+str(l)+")"
                            l += 1
                        else:
                            break
                    with open ("AddCode_Simple.txt",mode="w",encoding=Encoding) as f:
                        f.write("")
                    with open ("AddCode_Simple.txt",mode="r",encoding=Encoding) as f:
                        addAns = input (f"{AddName}に追加したいコードをAddCode_Simpleに書き込んでyを入力してください\ny以外を入力でキャンセル")
                        if addAns == "y":
                            addText = f.readlines()
                            # input (addText)
                            addCodelist = []
                            ju = False
                            for i in addText:
                                if "#" in i:
                                    unlock_codes[AddName] = i
                                    ju = True
                                else:
                                    addCodelist.append(i)
                            addCode = "".join(addCodelist)
                            addCode = addCode.replace("\n","").replace(" ","")
                            read_code[AddName] = addCode
                            read_asmw[AddName] = ju
                            code_name.append(AddName)
                            # input (read_code)
                            # input (read_asmw)
                            print ("追加しました！");time.sleep(0.8)
                        else:  print ("キャンセル");time.sleep(0.8)
                    os.remove("AddCode_Simple.txt")
                elif Selected.startswith("m"):
                    Selected = Selected.replace("m","")
                    move_list = Selected.split()
                    first = code_name[int(move_list[0])-1];code_name.remove(first)
                    code_name.insert(int(move_list[1])-1,first)
                elif Selected.startswith("v"):
                    Selected = Selected.replace("v","")
                    if int(Selected) > 0:
                        clear()
                        print (code_name[int(Selected)-1])
                        try:  print (unlock_codes[code_name[int(Selected)-1]])
                        except:  pass
                        print (read_code[code_name[int(Selected)-1]])
                        enter()
                elif Selected.startswith("n"):
                    Selected = Selected.replace("n","")
                    ChangeNames = Selected.split(" ")
                    # input (ChangeNames)
                    oldName = code_name[int(ChangeNames[0])-1]
                    newName = "".join(ChangeNames[1:])
                    resultName = newName
                    q = 2
                    while True:
                        if resultName in code_name:
                            resultName = newName+"("+str(q)+")"
                            q += 1
                        else:
                            q = 0
                            newName = resultName
                            break
                    addAsm = read_asmw[oldName]
                    addCode = read_code[oldName]
                    # input (unlock_codes)
                    try:  addUnlock = unlock_codes[oldName];unlock_codes[newName] = addUnlock
                    except:  pass
                    addEnabled = True if oldName in Onlist else False
                    code_name.remove(oldName)
                    code_name.insert(int(ChangeNames[0])-1,newName)
                    read_asmw[newName] = addAsm
                    read_code[newName] = addCode
                    if addEnabled:
                        Onlist.remove(oldName)
                        Onlist.append(newName)
                elif Selected == "all":
                    ans = input ("本当に全てONにしますか?\n(yで実行,他でキャンセル)\n>>>")
                    if ans == "y":
                        Onlist.clear()
                        for add in code_name:
                            Onlist.append(add)
                    else:
                        print ("キャンセル");time.sleep(0.5)
                elif Selected == "clear":
                    ans = input ("本当に全てOFFにしますか?\n(yで実行,他でキャンセル)\n>>>")
                    if ans == "y":
                        Onlist.clear()
                    else:
                        print ("キャンセル");time.sleep(0.5)
                else:
                    if Selected.startswith('d'):
                        delete_mode = True
                        Selected = Selected.replace("d","")
                    elif Selected.startswith('c'):
                        copy_mode = True
                        Selected = Selected.replace("c","")
                    else:  pass
                    if '!' in Selected:
                        Selected_list = Selected.split('!')
                        Selected_list.sort(key=int)
                        Ad1 = int(Selected_list[0])
                        Ad2 = int(Selected_list[1])
                        selected_list = createList(Ad1,Ad2)
                        # input (selected_list)
                    else:  selected_list = Selected.split()
                    if delete_mode:  selected_list.sort(reverse=True)
                    for i in selected_list:
                        #  input (selected_list)
                        if int(i) > 0:
                            Sel_num = int(i)-1
                            Target = code_name[Sel_num]
                            if delete_mode:
                                try:  Onlist.remove(Target)
                                except:  pass
                                code_name.remove(Target)
                            elif copy_mode:
                                Target_copy = Target
                                w = 2
                                while True:
                                    if Target_copy in code_name:
                                        Target_copy = Target+"("+str(w)+")"
                                        w += 1
                                    else:
                                        code_name.append(Target_copy)
                                        add_code = read_code[Target]
                                        add_asm = read_asmw[Target]
                                        read_code[Target_copy] = add_code
                                        read_asmw[Target_copy] = add_asm
                                        w = 2
                                        break
                            else:
                                if Target in Onlist:
                                    Onlist.remove(Target)
                                else:
                                    Onlist.append(Target)
                        else:  print (Error)
                    try:  AutoSave_count -= 1
                    except:  pass
            except:
                print ("不正な数字です");time.sleep(0.5)
def Xml_Convert():
    clear()
    files = glob.glob("*.xml")
    i = 1
    for f in files:
        print (f'{str(i)}|{f}')
        i = i+1
    sel = input ('変換したいファイルを選択してください\n(間違った入力をすると自動でホームに戻ります)\n---{ Select: ')
    try:
        XMLCODE_CODE,XMLCODE_NAME,XMLCODE_ENABLED = [],[],[]
        if int(sel) > 0:  selK = int(sel)-1
        else:  print (Error);selK = 0
        Xml_name = files[selK]
        clear();print (Xml_name+"を"+Xmlslist_name+"に変換中です...\n")
        with open(Xml_name, mode='rt', encoding=Encoding) as f:
            xml_string = f.read().replace('\u3000','')
        root = ET.fromstring(xml_string)
        for name in root.iter('code'):
            ADD_CODE = (name.text)
            XMLCODE_CODE.append(ADD_CODE)
            
        for name in root.iter('enabled'):
            ADD_ENA = str(name.text)
            XMLCODE_ENABLED.append(ADD_ENA)
            
        for child in root:
            ADDCODE_NAME = (child.attrib["name"])
            XMLCODE_NAME.append(ADDCODE_NAME)
        RESULT_XML = []
        for x,i in enumerate(XMLCODE_NAME):
            RESULT_XML.append(i+"\n")
            v = "on\n" if XMLCODE_ENABLED[int(x)] == "true" else "off\n"
            RESULT_XML.append(v)
            RESULT_XML.append(XMLCODE_CODE[int(x)])
            RESULT_XML.append("\n"+Delimiter+"\n")
        with open(Xmlslist_name+Xml_name+".txt",mode = "wt",encoding = Encoding) as f:
            for p in RESULT_XML:
                f.write(str(p))
        print ("✓ 完了しました\n")
        time.sleep(1)
    except:
        Xml_name = 'None'
        print ('不正な数字です。');time.sleep(1)
def hexstr0(data): #0xFFFFFFFF, uppercase hex string
        return "0x" + hex(data).lstrip("0x").rstrip("L").zfill(8).upper()
class tcp_gecko:

    
    def test_connect(self, ip_local, Connect_to, Cafe_from):
        try:
            print (ip_local+' に接続しています...')
            s=socket.socket(socket.AF_INET,socket.SOCK_STREAM)
            s.connect((ip_local,Connect_to))
            s.close()
            print('接続しました!')
        except:  print ('WiiUとの接続中にエラーが発生しました lol');sys.exit()
    def Send(self, ip_local, uncode, debug_mode, OnCodes, result_codes, result_asmws, code_name):
        clear()
        d = 1
        cafe_list = []
        asm_list = []
        print ("┐")
        for i in OnCodes:
            print (f"│{i}");d = 0
            code_add = result_codes.get(i)
            asm_judge = result_asmws.get(i)
            # print (code_add)
            if asm_judge:  asm_list.append(code_add)
            else:  cafe_list.append(code_add)
        if d == 1:  print ("│None")
        print ("┘")
        cafe = "".join(cafe_list).replace(" ","").replace("\n","").replace("/","")
        asm = "".join(asm_list).replace("#","").replace(" ","").replace("\n","").replace("/","")
        unlock = "".join([uncode[i] for i in code_name if i in uncode]).replace("#","").replace(" ","").replace("\n","").replace("@","").replace("/","")
      #  print (uncode)
      #  print (unlock)
      #  print (cafe)
      #  print (asm)
        if debug_mode:  print ("デバッグモードのためコードを送信しませんでした");time.sleep(1)
        else:
            try:
                print ("送信中です...")
                s=socket.socket(socket.AF_INET,socket.SOCK_STREAM)
                s.connect((ip_local,Connect_to))
                s.send(bytes.fromhex('03'))
                s.send(bytes.fromhex(Cafe_from[1]))
                for x in range(math.floor(len(cafe)/8)):
                    s.send(bytes.fromhex('03'))
                    s.send(bytes.fromhex('0'+format(0x01133000+x*4,'X')+cafe[x*8:x*8+8]))
                s.send(bytes.fromhex('03'))
                s.send(bytes.fromhex(Cafe_from[0]))
                for x in range(math.floor(len(unlock)/16)):
                    s.send(bytes.fromhex('03'))
                    s.send(bytes.fromhex(unlock[x*16:x*16+16]))
                for x in range(math.floor(len(asm)/16)):
                    s.send(bytes.fromhex('03'))
                    s.send(bytes.fromhex(asm[x*16:x*16+16]))
                s.close()
            except:
                print ("WiiUとの接続中にエラーが発生しました");time.sleep(1)
class Search:
    def __init__(self):
        self.s=socket.socket(socket.AF_INET,socket.SOCK_STREAM,socket.IPPROTO_TCP)
        self.s.connect((ipadr,Connect_to))
    def n(self,address):
        if(not self.g(address,8)):
            raise BaseException("Address range not valid")
        if(not self.q(address,8,"write")):
            raise BaseException("Cannot write to address")
        self.s.send(b"\x0C")
        request=struct.pack(">I",int(address))
        self.s.send(request)
        value=struct.unpack(">I",self.s.recv(32))[0]
        return socket.inet_ntoa(struct.pack(">L",int(hex(value),16)))
    
    def g(self,address,length):
        if(0x01000000<=address and address+length<=0x01800000):  return True
        elif(0x0E000000<=address and address+length<=0x10000000):  return True
        elif(0x10000000<=address and address+length<=0x50000000):  return True
        elif(0xE0000000<=address and address+length<=0xE4000000):  return True
        elif(0xE8000000<=address and address+length<=0xEA000000):  return True
        elif(0xF4000000<=address and address+length<=0xF6000000):  return True
        elif(0xF6000000<=address and address+length<=0xF6800000):  return True
        elif(0xF8000000<=address and address+length<=0xFB000000):  return True
        elif(0xFB000000<=address and address+length<=0xFB800000):  return True
        elif(0xFFFE0000<=address and address+length<=0xFFFFFFFF):  return True
        else:  return False
    def q(self,address,length,access):
        if(0x01000000<=address and address+length<=0x01800000):
            if(access.lower()=="read"):  return True
            if(access.lower()=="write"):  return False
        elif(0x0E000000<=address and address+length<=0x10000000):
            if(access.lower()=="read"):  return True
            if(access.lower()=="write"):  return False
        elif(0x10000000<=address and address+length<=0x50000000):
            if(access.lower()=="read"):  return True
            if(access.lower()=="write"):  return True
        elif(0xE0000000<=address and address+length<=0xE4000000):
            if(access.lower()=="read"):  return True
            if(access.lower()=="write"):  return False
        elif(0xE8000000<=address and address+length<=0xEA000000):
            if(access.lower()=="read"):  return True
            if(access.lower()=="write"):  return False
        elif(0xF4000000<=address and address+length<=0xF6000000):
            if(access.lower()=="read"):  return True
            if(access.lower()=="write"):  return False
        elif(0xF6000000<=address and address+length<=0xF6800000):
            if(access.lower()=="read"):  return True
            if(access.lower()=="write"):  return False
        elif(0xF8000000<=address and address+length<=0xFB000000):
            if(access.lower()=="read"):  return True
            if(access.lower()=="write"):  return False
        elif(0xFB000000<=address and address+length<=0xFB800000):
            if(access.lower()=="read"):  return True
            if(access.lower()=="write"):  return False
        elif(0xFFFE0000<=address and address+length<=0xFFFFFFFF):
            if(access.lower()=="read"):  return True
            if(access.lower()=="write"):  return False
        else:  return False
def create_nnid():
    formatedNNID = formatCode(str(input("NNID\n>>>")).encode("UTF-16be").hex().ljust(256,"0").replace("0"*16,""))
    created_NNIDcode = f"30000000 10AD1C58\n10000000 50000000\n01100020 00000050\n{formatedNNID.upper()}\n00000000 000000FF\nD0000000 DEADCAFE"
    print (created_NNIDcode);enter()
def ip():
    ys = Search()
    print("白: "+ys.n(0x10F9D8EC))
    print("緑: "+ys.n(0x10F9D8FC))
    print("赤: "+ys.n(0x10F9D90C))
    print("青: "+ys.n(0x10F9D91C))
    print("桃: "+ys.n(0x10F9D92C))
    print("橙: "+ys.n(0x10F9D93C))
    print("黄: "+ys.n(0x10F9D94C))
    print("水: "+ys.n(0x10F9D95C));enter()
def Main(Mainlist_name):
    if J_import__:
        try:
            print ("セットアップが完了しました。");sys.exit()
        except:  pass
  #  print (readcode)
  #  print (readasmw)
  #  print (unlock_code)
  #  print (Onlist)
    files = glob.glob("*.txt")
    files.append("新しく"+Mainlist_name+".txtを作る")
    i = 1
    for f in files:
        print (f'{str(i)}|{f}')
        i = i+1
    sel = input ('読み込むファイルを選択してください\n---{ Select: ')
    try:
        XMLCODE_CODE,XMLCODE_NAME,XMLCODE_ENABLED = [],[],[]
        if int(sel) > 0:  selK = int(sel)-1
        else:  print (Error);selK = 0
        Mainlist_name = files[selK]
        Mainlist_name = Mainlist_name.replace("新しく","").replace("を作る","")
        open_main = open_list()
        code_list = (open_main.open(Mainlist_name))
        code_name,code_main,result_enabs = [],[],[]
        codetime = False
        for i in code_list:
            #print (i)
            i = i.replace("\n","")
            if codetime:
                code_main.append(i)
            if i == Delimiter:
                codetime = False
            elif i == "on" or i == "off":
                result_enabs.append(i)
                codetime = True
            else:
                if codetime == False:
                    iv = i
                    v = 2
                    while True:
                        if iv in code_name:
                            iv = i+"("+str(v)+")"
                            v += 1
                        else:
                            code_name.append(iv.replace("\n",""))
                            v = 0
                            break
                    codetime = False
        result_names,result_codes,result_asmws,unlock_code = [],[],[],{}
        result_names = [i for i in code_name]
        adds = []
        asm_judge = False
        p = 0
        for i in code_main:
            if i == Delimiter:
                addcode = "\n".join(adds)
        #        print (addcode)
                if asm_judge:  result_asmws.append(True);result_codes.append(addcode)
                else:  result_asmws.append(False);result_codes.append(addcode)
                adds.clear()
                p += 1
                asm_judge = False
            else:
                # input (code_main)
                if "#" in i:  asm_judge = True;unlock_code[code_name[p]] = i
                else:  adds.append(i)
        reads = (open_main.read(result_names,result_codes,result_enabs,result_asmws))
        readcode,readasmw,Onlist = reads[0],reads[1],reads[2]
    except:
        print ("不正な数字です");sys.exit()
    clear()
    TcpGecko = tcp_gecko()
    debug_mode = False
    ip_local = ipadr
    TcpGecko.test_connect(ip_local, Connect_to, Cafe_from)
        
    s = "DEBUG" if debug_mode else ip_local
    while True:
        clear()
        Command = input (f"┌SimpleGecko ✼ [{s}]\n└>")
        if Command == "?h":  clear();help_command()
        elif Command == "?l":  Code_Manager(code_name, Onlist, readcode, unlock_code, AutoSave_count, readcode, readasmw, Mainlist_name)
        elif Command == "?x":  Xml_Convert()
        elif Command == "1":  TcpGecko.Send(ip_local, unlock_code, debug_mode, Onlist, readcode, readasmw, code_name)
        elif Command == "?i":  ip()
        elif Command == "?n":  clear();create_nnid()
        elif Command == "?e":  print ("Good by!");break
if __name__ == "__main__":  Main(Mainlist_name)
