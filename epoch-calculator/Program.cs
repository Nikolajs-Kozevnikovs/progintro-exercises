using System.Runtime.CompilerServices;

int time_seconds = 1757660084;

int time_years = time_seconds / (365*60*60*24);
int time_days = (time_seconds - time_years*365*24*60*60)/60/60/24;
Console.WriteLine($"Since 1970, {time_years} years and {time_days} days have passed.");
Console.WriteLine($"This means that it should be year {time_years+1970} now, while day is not going to be precise since the 366th day in every 4th year was not taken into account.");