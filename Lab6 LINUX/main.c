#include <stdio.h>
#include "functions.h"

int main()
{
    int a;
    int b;
    printf("Enter two integers divided by dot:\n");
    scanf("%d.%d",&a,&b);
    printf("Result is: %d\n",f4(a,b));
    return 0;
}
