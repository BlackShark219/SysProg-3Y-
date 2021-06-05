#include <stdio.h>
#include <time.h>
#include "functions.h"
#include <string.h>

int main()
{

time_t mytime = time(NULL);
char * time_str = ctime(&mytime);
time_str[strlen(time_str)-1] = '\0';
int a;
int b;
FILE *myFile;
myFile=fopen("XY.txt","r");
fscanf(myFile,"%d.%d",&a,&b);
int result = f4(a,b);
printf("%s:\t %d\n", time_str, result);
FILE *f = fopen("f4.txt", "a");
if (f == NULL)
{
   printf("Error opening file!\n");
   return 1;
}
fprintf(f, "%s:\t %d\n", time_str, result);
return 0;
}

