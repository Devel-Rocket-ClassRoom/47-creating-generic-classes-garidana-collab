using System;
using System.Collections.Generic;
using System.Text;


// 제네릭 클래스 생성
// Queue 직접 구현해보는 코드
class SimpleQueue<T>
{
    private T[] _items; // 배열 
    private int _count;  // 현재 배열에 저장된 아이템 수

    // 생성자로 용량을 매개변수로 받아 아이템 배열의 길이로 사용
    // 배열내의 아이템 수;
    public SimpleQueue(int capacity)
    {
        _items = new T[capacity];
    }

    // _count 접근 속성
    public int Count => _count;

    // 내용물 수가 아이템 배열의 길이와 같을때
    public bool IsFull => _count == _items.Length;

    // 내용물의 수가 0일때
    public bool IsEmpty => _count <= 0;

    // 배열에 항목 추가 및 내용물 갯수 추가
    public void Enqueue (T item)
    {
        if (IsFull)
        {
            Console.WriteLine("큐가 가득찼습니다.");
            return;
        }
        _items[_count] = item;
        _count++;
    }

    // 배열에 내용물 꺼내고 배열 갱신 후 내용물 숫자 감소
    public T Dequeue()
    {
        
        if (IsEmpty)
        {
            Console.WriteLine("큐가 비어있습니다.");
            return default(T);
        }
        T first = _items[0];

        // 맨앞 인덱스의 요소가 빠지면 뒤의 요소들을 하나씩 앞으로 당겨오는 식
        for (int i = 0; i < _count - 1; i++)
        {
            _items[i] = _items[i + 1];
        }
        _count--;
        return first;
    }

    // 가장 첫 내용물에 접근후 내용물 갯수는 유지
    public T Peek()
    {
        if (IsEmpty)
        {
            Console.WriteLine("큐가 비어있습니다.");
            return default(T);
        }
        T first = _items[0];
        return first;
    }
}