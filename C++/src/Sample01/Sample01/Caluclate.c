#include <stdio.h>
int main(int argc, char** argv) {

	//�ϐ��̐���
	int a, b;

	//�ϐ��ɐ��l�̑��
	a = 10;
	b = 5;

	//���s����
	//%d �����l��10�i���ŕ\��
	printf("%d + %d = %d\n", a, b, a + b);
	printf("%d - %d = %d\n", a, b, a - b);
	printf("%d * %d = %d\n", a, b, a * b);
	printf("%d / %d = %d\n", a, b, a / b);

	return 0;
}