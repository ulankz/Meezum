
using System;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
public class Benchmark : IDisposable 
{
	private readonly Stopwatch timer = new Stopwatch();
	private readonly string benchmarkName;

	public Benchmark(string benchmarkName)
	{
		this.benchmarkName = benchmarkName;
		timer.Start();
	}

	public void Dispose() 
	{
		timer.Stop();
		Debug.Log(benchmarkName + " " + timer.Elapsed);
	}
}