import cv2
import numpy as np

ScreenCut = '--------------------------------------------'
Titleup = '\n' + '【 OpenCV を使った画像処理ツール v1.3 】'
print(ScreenCut)
print(Titleup + '\n')
print('※特殊記号のない名前の画像にしましょう' + '\n')
print(ScreenCut)

def ScreenBuffer():

    ImagePath = input('\n' + '画像のディレクトリを入力：')

    #DrawText = input('\n' + '描画する文字を入力：')

    #PickColor = input('\n' + '文字色のRGBを入力：')
    
    #cv2.putText(img,
    #        DrawText,
    #        org=(10, 50),
    #        fontFace=cv2.FONT_HERSHEY_DUPLEX,
    #        fontScale=1.5,
    #        color=(130, 130, 130),
    #        thickness=2,
    #        lineType=cv2.LINE_AA)

    img = cv2.imread(ImagePath)
    cascade_path = './haarcascades/haarcascade_frontalface_alt.xml'

    img_gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

    cv2.imshow(ImagePath, img_gray)
    cv2.waitKey(0)

    cascade = cv2.CascadeClassifier(cascade_path)

    # 顔の検出
    face_list = cascade.detectMultiScale(img, minSize = (20, 20))

    if len(face_list):
        for (x,y,w,h) in face_list:
            #検出枠の表示
            cv2.rectangle(img, (x,y), (x+w, y+h), (0, 0, 255), thickness=3)
            print('\n' + '顔を発見しました')
            cv2.imshow(ImagePath, img)
            cv2.waitKey(0)
        #cv2.destroyAllWindows()
    else:
        print('\n' + '見つかりませんでした ...' + '\n')

    print('\n' + 'Successfully ...' + '\n')
    print(ScreenCut)
    ScreenBuffer()
ScreenBuffer()