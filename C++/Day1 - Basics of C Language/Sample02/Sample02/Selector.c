#include <stdio.h>

int main(int argc, char** argv) {

	//���̉��x
	/// <param name="water_temp">�D���Ȑ��l</param>
	double water_temp = 1.25;

	//���x�ɂ���������
	printf("���̉��x�F%1f\n", water_temp);

	if (water_temp > 100.0){
		//100���ȏ�Ȃ�C��
		printf("�C��\n");
	}

	else if (water_temp > 0){
		//100���ȉ�0���ȏ�Ȃ�t��
		printf("�t��\n");
	}

	else{
		//0���ȉ��Ȃ��
		printf("��\n");
	}
	return 0;
}