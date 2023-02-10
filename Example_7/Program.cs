//Задача про двух друзей и собаку
double distance = 10000, time = 0;
int firstFSpeed = 2, secondFSpeed = 1, dogSpeed = 5,
count = 1, friend = 2;
while(distance>10)
{
    if(friend==1)
    {
        time = distance/(firstFSpeed+dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance/(dogSpeed-secondFSpeed);
        friend = 1; 
    }
    distance = distance - (firstFSpeed-secondFSpeed)*time;
    count++;
}
Console.WriteLine(count);
 
