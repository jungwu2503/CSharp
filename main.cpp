#include <stdio.h>
#include <malloc.h>
#include <string.h>
#include "Student.h"
#include "Student.h"


void printAll(Student *h)
{
	Student *tmp = h;

	while (tmp != NULL) {
		tmp->print();
		tmp = tmp->next;
	}
}

void add(Student **header,char *name,int total) {
	Student *newStudent = new Student(name,total);

	if (*header == NULL) {
		*header = newStudent;
		return;
	}

	Student *tmp = *header;

	while (tmp->next != NULL) {
		tmp = tmp->next;
	}
	tmp->next = newStudent;
}

void main()
{	
	/*Student x("kim",10);
	Student y("lee",20);

	x.print();
	y.print();*/

	/*Student arr[100];

	arr[0].setName("kim");
	arr[1].setName("lee");
	arr[2].setName("park");*/

	/*Student *x = new Student("kim",10);
	Student *y = new Student("lee",20);

	x->print();
	y->print();

	delete x;
	delete y;*/

	/*
	Student x("kim",100);
	x.print();

	Student *p;
	p = new Student("kim",100);
	p->print();
	*/
	/*
	Student st[100];
	int n = 0;

	for(int i = 0; i < 30; i++) {
		st[i].setName("kim");
		st[i].setTotal(100);
	}
	n = 30;
	*/
/*
	Student *st[100];
	int n = 0;
	for(int i = 0; i < 30; i++) {
		st[i] = new Student();
		st[i]->setName("kim");
		st[i]->setTotal(100);
	}
	n = 30;
*/
	/*
	Student **st; 

	st = new Student*[100]; 
	int n = 0;

	for(int i = 0; i < 100; i++) {
		st[i] = NULL;
	}

	for(int i = 0; i < 30; i++) {
		st[i] = new Student();  
		st[i]->setName("kim");
		st[i]->setTotal(100);
	}
	n = 30;

	for(int i = 0; i < 100; i++) {
		if (st[i] != NULL) {
			delete st[i];
		}
	}
	delete []st; */

	Student *s = NULL;

	add(&s,"kim",100);
	add(&s,"lee",30);
	add(&s,"park",50);
	add(&s,"ok",20);
	add(&s,"ok1",30);
	add(&s,"ok2",60);

	printAll(s);

	Student *tmp;
	Student *next;
	tmp = s;

	while (tmp != NULL) {
		next = tmp->next;
		delete tmp;
		tmp = next;
	}
}