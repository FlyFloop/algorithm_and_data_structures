#include <iostream>
#include <stdlib.h>
#include <stdio.h>
struct n{
    int data;
    n * next;
};
typedef n node;
void printNode(node *root){
    node * iter = root;
    while(iter -> next != root){
        printf("%d\n",iter -> data);
        iter = iter -> next;
    }
    printf("%d",iter -> data);
}
void addNode(node *root,int data){
    node * iter = root;
    while( iter -> next != root){
        iter = iter -> next;
    }
    node * temp = (node *)malloc(sizeof(node));
    iter -> next = temp;
    temp -> next = root;
    temp -> data = data;

}
void deleteNode(node *root,int data){
    node *iter=root;
    node *temp= (node *) malloc(sizeof(node));
    if (iter -> data == data){
        while (iter -> next != root){
            iter = iter -> next;
        }
        temp = iter;
        iter = iter->next;
        free(temp);
        return;
    }

}
int main() {
    node *root = (node*) malloc(sizeof(node));
    root -> data = 10;
    root -> next = root;
    addNode(root,11);
    addNode(root,12);
    addNode(root,13);
    printNode(root);

    return 0;
}
