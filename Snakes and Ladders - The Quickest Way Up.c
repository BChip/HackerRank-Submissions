#include <stdio.h>

int transition[100];
int boardCount[100];
int queue[100];
int size = 0;

void calc(int cell) {
    size--;
    for (int i = 0; i < size; i++) {
        queue[i] = queue[i+1];
    }

    for (int i = 1; i <= 6; i++) {
        int newCell = cell + i;
        int newCount = boardCount[cell] + 1;
        if (newCell < 100 && newCount < boardCount[newCell]) {
            boardCount[newCell] = newCount;

            if (transition[newCell] != 0 &&
                boardCount[transition[newCell]] > newCount) {
                boardCount[transition[newCell]] = newCount;
                queue[size++] = transition[newCell];
            }
            else {
                queue[size++] = newCell;
            }
        }
    }


}

int main() {

    int t;
    scanf("%d", &t);
    while (t--) {
        int ladders;
        for (int i = 0; i < 100; i++) {
            boardCount[i] = 1000;
            transition[i] = 0;
        }
        scanf("%d", &ladders);
        for (int i = 0; i < ladders; i++) {
            int start, end;
            scanf("%d %d", &start, &end);
            transition[start-1] = end - 1;
        }
        int snakes;
        scanf("%d", &snakes);
        for (int i = 0; i < snakes; i++) {
            int start, end;
            scanf("%d %d", &start, &end);
            transition[start-1] = end - 1;
        }

        boardCount[0] = 0;
        size = 1;
        queue[0] = 0;

        while (size) {
            calc(queue[0]);
        }
        printf("%d\n", boardCount[99] == 1000 ? -1 : boardCount[99]);
    }


    return 0;
}