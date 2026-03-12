using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;



class Converter<TInput, TOutput>
{
    


    public Func<TInput, TOutput> _convertFunc;
    // 변환기 생성자
    // Converter의 매개변수인 func 함수를 선언된 필드 _convertFunc에 할당
    public Converter (Func<TInput, TOutput> func)
    {
         
        _convertFunc = func;
    }

    // 
   public TOutput Convert (TInput input)
    {

        return _convertFunc(input);
    }

    //결과 배열 생성
    public TOutput[] ConvertAll(TInput[] inputs)
    {
        // TOutput[] 은 배열이기 때문에 배열을 생성해서 각 반복문의 결과물을
        // 할당 해주어야 함으로 배열을 먼저 생성
        // TInput[] intputs의 길이 만큼 TOutput[] 배열 생성
        TOutput[] results = new TOutput[inputs.Length];

        for (int i = 0; i < inputs.Length; i++)
        {
            // results 배열 변수에 Convert 함수로 input을 변환한 값을 할당
            results[i] = Convert(inputs[i]);
        }
        return results;
    }
}
