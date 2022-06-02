#include <iostream>
#include <stdio.h>
#include <stdlib.h>

struct n{
    //def node
    int data;
    n* next;
};
typedef  n node;

void printNode(node *root){
    node * iter = root;
    while(iter != NULL){
        printf("%d\n",iter -> data);
        iter = iter -> next;
    }
}
void addNode(node *root,int data){
   node *iter = root;
    while (iter -> next != NULL){
        iter = iter -> next;
        continue;
    }
    node * temp = (node *) malloc(sizeof(node));
    temp -> next = NULL;
    temp -> data = data;
    iter -> next = temp;
}
void  removeNode(node *root,int data){
    node *iter = root;
    node *temp;
    if (iter -> data == data){
        temp = iter;
        iter = iter-> next;
        free(temp);
        return;
    }
    while(iter -> next -> data != data && iter -> next != NULL){
        iter = iter -> next;
    }
    if (iter -> next == NULL){
        return;
    }
    temp = iter -> next;
    iter -> next = iter -> next -> next;
    free(temp);

}
int main() {
    node * root;//root(head) node
    root = (node *) malloc(sizeof(node));//node * typecast
    root -> data = 10;
    root -> next = NULL; //first node

    //added nodes with loop

    addNode(root,20);
    addNode(root,30);
    addNode(root,40);
    removeNode(root,10);
    addNode(root,50);

    printNode(root);
    return 0;
}
