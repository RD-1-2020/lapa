#include <iostream>
#include <initguid.h>
#import "COM_example_framework.tlb" no_namespace

using namespace std;

int main()
{
	CoInitialize(NULL);
	
	IMyInterfacePtr myDrink(__uuidof(Pdf_Reader));
	cout << myDrink->get_Hello();
	return 0;
}