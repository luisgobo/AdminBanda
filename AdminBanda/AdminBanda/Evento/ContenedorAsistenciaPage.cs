﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AdminBanda.Evento
{
	public class ContenedorAsistenciaPage : ContentPage
	{
		public ContenedorAsistenciaPage ()
		{
			Content = new StackLayout {
				Children = {
					new Label { Text = "Asistencia" }
				}
			};
		}
	}
}