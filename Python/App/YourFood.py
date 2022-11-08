import sys
import random

TitleUp = '\n' + '【 好きな食べ物ジェネレーター 】' + '\n'
Exit = '...'
print(TitleUp)

#起動

def Command():

    #コマンド
    print('作成 [1]' + '\n' + '情報 [2]' + '\n' + '終了 [3]' + '\n')

Command()

def SelectLine():

    Value = input('：')

    if Value == '1':
        #果実＋料理＋甘党＋野菜

        Fruits = 'りんご', 'みかん', 'もも', 'すいか', 'バナナ', 'さくらんぼ', 'なし', 'ぶどう', 'マンゴー', 'キウイ', 'パイナップル', 'メロン', 'いちご', '梅干し'

        Foods =  'ご飯', 'パン', 'うどん', 'そば', 'ラーメン', 'チャーハン', '天ぷら', '焼き魚', 'ハンバーグ', 'ハンバーガー', 'ステーキ', 'カレー', 'オムライス', '寿司', 'とんかつ', '生姜焼き', '味噌汁', 'パスタ', '納豆'

        Sweets = 'アイス', 'チョコレート', 'タピオカ', 'パフェ', 'ショートケーキ', 'わらび餅', 'ティラミス', 'クッキー', 'マフィン', 'マカロン', '大福', 'カステラ', 'プリン', 'ポップコーン'

        Vegetables = '胡瓜(きゅうり)', '南瓜(かぼちゃ)', 'きゃべつ', 'トマト', 'ブロッコリー', '玉蜀黍(とうもろこし)', '玉葱(たまねぎ)', '白菜(はくさい', '法蓮草(ほうれんそう)', 'じゃがいも', 'アスパラガス', '薩摩芋(さつまいも)'


        RandomFood = (''.join((random.choice(Fruits + Foods + Sweets + Vegetables) for i in range(1))))

        #Rf = RandomFood
    
        print('\n' + '<<<  ' + RandomFood + '  >>>')

        print('\n' + Exit + '\n')

        Command()
        SelectLine()

    if Value == '2':
        print('\n' + 'Copyright © Pop-Apple 2022  |  ver 1.0.1')
        print('\n' + Exit + '\n')

        Command()
        SelectLine()

    if Value == '3':
        exit

    else:
        print('\n' + 'Error / 不明な値' + '\n')

        Command()
        SelectLine()

SelectLine()