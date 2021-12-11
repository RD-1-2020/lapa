#include "pch.h"
#include "FileWriter.h"

#include <fstream>
#include <ios>


void FileWriter::write(char* str, char* fileName)
{
	std::ofstream fout(fileName, std::ios_base::app);
	fout << str << std::endl;
	fout.close();
}

void seyHi()
{
	std::cout << "Hello from c++" << std::endl;
}

