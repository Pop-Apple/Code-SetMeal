#include <stdio.h>

int main(int argc, char** argv) {

	//iに1を代入
	int i = 1;

	//処理の繰り返し
	/// <param name="i">繰り返し回数</param>
	while (i <= 100) {
		printf("%d \n", i);
		i++;
	}

	printf("\n");

	return 0;
}