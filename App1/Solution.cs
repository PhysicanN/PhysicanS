using Android.Widget;
using System;
using System.Reflection.Emit;

namespace Physican.Solution
{
    public class Solution
    {
        public float piA = 3.14f; //сокращенное число пи
        public float pi = 3.1415926535f; //полное число пи
        public float s; //расстояние
        public float v; //скорость
        public float t; //время
        public float p; //плотность вещества
        public float m; //масса вещества
        public float V; //объем вещества
        public float Δl; // Удлинение тела
        public float elasticityF; //Сила упругости
        public float k; //Коэффициент пропорциональности
        public string stringSolution; //текстовое поле с решением
        public float chislo() { 
            MathF.Pow(10,3); 
            return chislo(); 
        }
         void Sol()
        {
            stringSolution = "Решение:" +
                "/n v=s/t " +
                "/n v= " + s.ToString() + "/" + t.ToString() + " = " + (s / t).ToString(); //находим скорость от расстояния и времени
            stringSolution = "Решение:" +
               "/n s=v*t " +
               "/n s= " + v.ToString() + "*" + t.ToString() + " = " + (v * t).ToString(); //находим расстояние от скорости и времени
            stringSolution = "Решение:" +
               "/n t=s/v " +
               "/n t= " + s.ToString() + "/" + v.ToString() + " = " + (s / v).ToString(); //находим время от расстояния и скорости
            stringSolution = "Решение:" +
                "/n p=m/V" +
                "/n p=" + m.ToString() + "/" + V.ToString() + "=" + (m / V).ToString(); //находим плотность вещества от массы и объема
            stringSolution = "Решение:" +
                "/n m=p*V" +
                "/n m=" + p.ToString() + "*" + V.ToString() + "=" + (p * V).ToString(); //находим массу вещества от плотности и объема
            stringSolution = "Решение:" +
                "/n V=m/p" +
                "/n V=" + m.ToString() + "/" + p.ToString() + "=" + (m / p).ToString(); //находим объем вещества от массы и плотности
            stringSolution = "Решение:" +
                "/n Fупр=k*Δl" +
                "/n Fупр=" + k.ToString() + "*" + Δl.ToString() + "=" + (k / Δl).ToString(); //находим силу упругости от коэффициента пропорциональности и удлинения тела
            stringSolution = "Решение:" +
                "/n Δl=Fупр/k" +
                "/n Δl=" + elasticityF.ToString() + "/" + k.ToString() + "=" + (elasticityF / k).ToString(); //находим удлинение тела от силы упругости и коэффициента пропорциональности
            stringSolution = "Решение:" +
                "/n k=Fупр/Δl" +
                "/n k=" + elasticityF.ToString() + "/" + Δl.ToString() + "=" + (elasticityF / Δl).ToString(); //находим коэффициент пропорциональности от силы упругости и удлинения тела
        }
    }

}
