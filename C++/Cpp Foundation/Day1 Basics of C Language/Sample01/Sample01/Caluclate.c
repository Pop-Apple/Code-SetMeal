#include <stdio.h>
int main(int argc, char** argv) {

	//変数の生成
	int a, b;

	//変数に数値の代入
	a = 10;
	b = 5;

	//実行結果
	//%d 整数値を10進数で表示
	printf("%d + %d = %d\n", a, b, a + b);
	printf("%d - %d = %d\n", a, b, a - b);
	printf("%d * %d = %d\n", a, b, a * b);
	printf("%d / %d = %d\n", a, b, a / b);

	return 0;
}