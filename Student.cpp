#include "Student.h"
#include "string.h"
#include "stdio.h"

// implementation 

Student::Student() {
	name = NULL;
	total = 0;
    next = NULL;
}

Student::Student(char *name,int total) {
	this->name = strdup(name);
	this->total = total;
    next = NULL;
}
void Student::setName(char *s) {
	name = strdup(s);
}
char* Student::getName() {
	return name;
}
// :: scope resolution operator
void Student::print() {
	printf("%s : %d\n",name,total);
}

Student::~Student() {
	if (name != NULL) delete []name;
	name = NULL;
	//printf("%s here\n", name);
}