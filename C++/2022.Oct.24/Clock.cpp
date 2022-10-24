#include <iostream>
#include <ctime>

using namespace std;

int main() {
    time_t currentTime;
    struct tm *localTime;

    time(&currentTime);                   
    localTime = localtime(&currentTime);

    int Day    = localTime->tm_mday;
    int Month  = localTime->tm_mon + 1;
    int Year   = localTime->tm_year + 1900;
    int Hour   = localTime->tm_hour;
    int Min    = localTime->tm_min;
    int Sec    = localTime->tm_sec;

    cout << "The current date/time is: " << Month << "/" << Day << "/" << Year << " - " << Hour << ":" << Min << ":" << Sec << endl;

    return 0;
}
