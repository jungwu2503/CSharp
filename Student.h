// specification : ¸í¼¼
/*

*/

#ifndef _STUDENT_H
#define _STUDENT_H


class Student {
private:
	char *name;
	int total;
public:
    Student *next;
public:	
	Student();
	Student(char *name,int total);
	~Student();
	void setName(char *s);
	char* getName();
	inline void setTotal(int x) {
		total = x;
	}
	void print();
};

#endif