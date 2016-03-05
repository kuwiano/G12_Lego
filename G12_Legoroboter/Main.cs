﻿
using System;
using MonoBrickFirmware;
using MonoBrickFirmware.Display.Dialogs;
using MonoBrickFirmware.Display;
using MonoBrickFirmware.Movement;
using System.Threading;

namespace MonoBrickHelloWorld
{
	class MainClass //test
	{
		public static void Main (string[] args)
		{
			InfoDialog dialog = new InfoDialog ("Attach a motor to port A", "information");
			dialog.Show ();//Wait for enter to be pressed
			Motor motor = new Motor (MotorPort.OutA);
			motor.SetSpeed (50);
			Thread.Sleep (3000);
			motor.Off ();
			Lcd.Clear ();
			Lcd.Update ();
		}
	}
}

