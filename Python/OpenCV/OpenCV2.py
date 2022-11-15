import cv2
import numpy as np

ScreenCut = '--------------------------------------------'
Titleup = '\n' + '【 OpenCV を使った画像処理ツール v1.2 】'
print(ScreenCut)
print(Titleup + '\n')
print('※特殊記号のない名前の画像にしましょう' + '\n')
print(ScreenCut)

def ScreenBuffer():

    ImagePath = input('\n' + '画像のディレクトリを入力：')

    DrawText = input('\n' + '描画する文字を入力：')

    #PickColor = input('\n' + '文字色のRGBを入力：')

    img = cv2.imread(ImagePath)

    print('\n' + 'Successfully ...' + '\n')
    print(ScreenCut)

    cv2.putText(img,
            DrawText,
            org=(10, 50),
            fontFace=cv2.FONT_HERSHEY_DUPLEX,
            fontScale=1.5,
            color=(130, 130, 130),
            thickness=2,
            lineType=cv2.LINE_AA)

    cv2.imshow(ImagePath, img)
    cv2.waitKey(0)
    cv2.destroyAllWindows()

    ScreenBuffer()
ScreenBuffer()