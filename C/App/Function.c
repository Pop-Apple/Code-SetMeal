#include <stdio.h>

//プロトタイプ宣言
double avg(double, double);

int main(int argc, char** argv) {
	double d1, d2, d3;
	double a = 1.2, b = 3.4, c = 2.7;

	d1 = avg(a, b);
	d2 = avg(4.1, 2.7);
	d3 = avg(c, 2.8);

	printf("di = %f,d2 = %f,d3 = %f\n", d1, d2, d3);
	return 0;
}

//平均を求める関数の定義
double avg(double m, double n)
{
	//rに代入
	double r = (m + n) / 2.0;
	return r;
}