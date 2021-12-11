#pragma once
#include <string>
#include <iostream>

class FileWriter
{
public:
	void write(char* str, char* fileName);
};

void seyHi();

extern "C" __declspec(dllexport) void* fileWriterCreate()
{
	return (void*)(new FileWriter);
}

extern "C" __declspec(dllexport) void fileWriterWrite(FileWriter * writer, char* fileName, char* fileText)
{
	writer->write(fileText, fileName);
}

extern "C" __declspec(dllexport) void seyHiFromLib()
{
	seyHi();
}

