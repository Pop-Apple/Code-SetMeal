import cv2
import numpy as np

Titleup = '【 OpenCV を使った画像処理ツール v1.0 】'
print(Titleup +'\n')
print('※※ 空白が入っていない名前の画像にしましょう ※※' +'\n' + '\n')

def Function1():

    ImagePath = input('\n' + '画像のディレクトリを入力：')

    img = cv2.imread(ImagePath)

    cv2.imshow(ImagePath, img)
    cv2.waitKey(0)
    cv2.destroyAllWindows()
    Function1()

Function1()