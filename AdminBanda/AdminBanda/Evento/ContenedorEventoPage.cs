﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AdminBanda.Evento
{
	public class ContenedorEventoPage : ContentPage
	{
		public ContenedorEventoPage ()
		{
			Content = new StackLayout {
				Children = {
					new Label { Text = "Eventos" }
				}
			};
		}
	}
}