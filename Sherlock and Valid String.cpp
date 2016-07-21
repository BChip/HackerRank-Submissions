#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
#include<set>
using namespace std;


int main() 
{
    string input;
    cin>>input;
    long long int array[26] = {0};
    for(int i=0;i<input.length();i++)
        array[input[i]-'a']++;
    std::set<int> arr;
    for(int i=0;i<26;i++)
        if(array[i]>0)
            arr.insert(array[i]);
    if(arr.size()>2)
        cout<<"NO";
    else
    {
        int sum = 0;
        for(int i=0;i<arr.size();i++)
        {
            int count = 0;
            for(int j=0;j<26;j++)
                if(*std::next(arr.begin(), i)==array[j])
                    count++;
            if(count>1)
                sum++;
        }
        if(sum>1)
            cout<<"NO";
        else    
            cout<<"YES";
    }
    return 0;
}