#include <stdio.h>

int main(int argc, char** argv) {

	//水の温度
	/// <param name="water_temp">好きな数値</param>
	double water_temp = 1.25;

	//温度による条件分岐
	printf("水の温度：%1f\n", water_temp);

	if (water_temp > 100.0){
		//100℃以上なら気体
		printf("気体\n");
	}

	else if (water_temp > 0){
		//100℃以下0℃以上なら液体
		printf("液体\n");
	}

	else{
		//0℃以下なら個体
		printf("個体\n");
	}
	return 0;
}