using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Класс Expression - представляет математическое выражение.
Поле ex - ссылка на метод-выражение, exEvent – событие,
происходящее при смене выражения, ExVal – метод вычисления
значения выражения для заданного значения аргумента,
конструктор.
• Класс ValueStore - хранит значение выражения. Поле exp – ссылка
на выражение, x0 - значение аргумента, expCurrValue – значение
выражения, CurrVal – ссылка на expCurrValue, Конструктор:
ValueStore(Expression e, double x)
• Классы находятся Expression и ValueStore в отношении агрегации.
• В основной программе создать объект me класса Expression,
использовать ссылку me в конструкторе объекта vs класса
ValueStore. Задавая разные выражения поля me.ex, выводить
значения vs. expCurrValue
 */
namespace Task02
{
	public delegate double ExpDel(double x);
	public delegate void ExpChanged();
	// TODO1: Определить событийный делегат ExpChanged!
	public class Expression
	{
		public event  ExpChanged OnExpChanged;
		// TODO2: Объявить событие OnExpChanged типа ExpChanged!
		ExpDel ex; // Поле для ссылки на метод-выражение
		public Expression(ExpDel e)
		{ // Конструктор
			ex = e;
		}
		public double ExVal(double x)
		{
			return ex(x);
		}
		// TODO3: При обновлении выражения в аксессорe!
		// инициировать событие:
		public ExpDel Ex { set {

				OnExpChanged();
				ex = value; } }
	}
	public class ValueStore
	{
		Expression exp;
		double x0; // точка - абсцисса
		double expCurrValue; // хранимое значение в x0
		public ValueStore(Expression e1, double x0)
		{
			exp = e1;
			this.x0 = x0;
			expCurrValue = exp.ExVal(x0);
		}
		public double CurrVal { get { return expCurrValue; } }
		public void OnExpChangedHandler()
		{
			expCurrValue = exp.ExVal(x0);
		}
		// TODO4: Определить метод OnExpChangedHandler(),!
		// изменяющий значение поля expCurrValue
		// на значение выражения exp в точке x0
	}
	class Program
	{
		static void Main()
		{
			Expression me = new Expression(x => { return x * x + 2 * x - 3; });
			ValueStore vs = new ValueStore(me, 0);
			me.OnExpChanged += vs.OnExpChangedHandler;
			// TODO5: Подписать объект vs на события объекта me!
			Console.WriteLine(vs.CurrVal);
			// изменяем выражение:
			me.Ex = x => { return Math.Sqrt(Math.Abs(x)); };
			Console.WriteLine(vs.CurrVal);
			me.Ex = x => { return Math.Sin(x); };
			Console.WriteLine(vs.CurrVal);
			me.Ex = x => { return x * x * x - 1; };
			Console.WriteLine(vs.CurrVal);
			Console.ReadKey();
		}
	}

}
