﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPoblacion
{
    public partial class Form1 : Form
    {
        private const int pop = 400;
        private List<int> enfermos;
        private Random rnd;
        private int counter;
        private int n;
        private int k;
        private bool turn;

        public Form1()
        {
            InitializeComponent();

            //Inicialización del grid
            InitializeGrid();

            //Inicialización de enfermo
            rnd = new Random();
            n = rnd.Next(1, 400);
            dgvPoblacion.Rows[GetY(n)].Cells[GetX(n)].Style.BackColor = Color.Green;
            enfermos = new List<int>();
            enfermos.Add(n);
            k = 2;
            turn = true;
        }

        /// <summary>
        /// Metodo que inicializa el grid
        /// </summary>
        private void InitializeGrid()
        {
            dgvPoblacion.RowCount = 20;
            dgvPoblacion.ColumnCount = 20;

            for (int i = 0; i < 20; i++)
            {
                dgvPoblacion.Rows[i].Height = 20;
                dgvPoblacion.Columns[i].Width = 20;
            }
        }

        /// <summary>
        /// Obtiene la posicion Y de un grid 20*20 sobre un numero entre 1-400
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        private int GetY(int pos)
        {
            return pos % 20 == 0 ? pos / 20 - 1 : pos / 20;
        }

        /// <summary>
        /// Obtiene la posicion X de un grid 20*20 sobre un numero entre 1-400
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        private int GetX(int pos)
        {
            return pos % 20 == 0 ? 19 : pos % 20 - 1;
        }

        /// <summary>
        /// Metodo que contagia cuadritos.
        /// -21 -20 -19
        ///  -1  C  +1
        /// +19 +20 +21
        /// </summary>
        private void Contagiar()
        {
            n = enfermos.Count;
            //Contagio
            for (int i=0;i < n;i++)
            {
                counter = 0;
                while (counter != k)
                {
                    try
                    {
                        switch (rnd.Next(1, 8))
                        {
                            case 1:
                                dgvPoblacion.Rows[GetY(enfermos[i] - 21)].Cells[GetX(enfermos[i] - 21)].Style.BackColor = Color.Green;
                                VerificarContagio(enfermos[i] - 21);
                                break;
                            case 2:
                                dgvPoblacion.Rows[GetY(enfermos[i] - 20)].Cells[GetX(enfermos[i] - 20)].Style.BackColor = Color.Green;
                                VerificarContagio(enfermos[i] - 20);
                                break;
                            case 3:
                                dgvPoblacion.Rows[GetY(enfermos[i] - 19)].Cells[GetX(enfermos[i] - 19)].Style.BackColor = Color.Green;
                                VerificarContagio(enfermos[i] - 19);
                                break;
                            case 4:
                                dgvPoblacion.Rows[GetY(enfermos[i] - 1)].Cells[GetX(enfermos[i] - 1)].Style.BackColor = Color.Green;
                                VerificarContagio(enfermos[i] - 1);
                                break;
                            case 5:
                                dgvPoblacion.Rows[GetY(enfermos[i] + 1)].Cells[GetX(enfermos[i] + 1)].Style.BackColor = Color.Green;
                                VerificarContagio(enfermos[i] + 1);
                                break;
                            case 6:
                                dgvPoblacion.Rows[GetY(enfermos[i] + 19)].Cells[GetX(enfermos[i] + 19)].Style.BackColor = Color.Green;
                                VerificarContagio(enfermos[i] + 19);
                                break;
                            case 7:
                                dgvPoblacion.Rows[GetY(enfermos[i] + 20)].Cells[GetX(enfermos[i] + 20)].Style.BackColor = Color.Green;
                                VerificarContagio(enfermos[i] + 20);
                                break;
                            case 8:
                                dgvPoblacion.Rows[GetY(enfermos[i] + 21)].Cells[GetX(enfermos[i] + 21)].Style.BackColor = Color.Green;
                                VerificarContagio(enfermos[i] + 21);
                                break;
                        }
                        counter++;
                    }
                    catch (ArgumentOutOfRangeException a)
                    {
                        counter++;
                    }
                }
            }          
        }


        /// <summary>
        /// Verifica el contagio y lo agrega a la lista
        /// </summary>
        /// <param name="c"></param>
        /// <param name="symbol"></param>
        /// <param name="mov"></param>
        private void VerificarContagio(int c)
        {
            if (c <= 0 || c >= 401) return;
            if (!enfermos.Contains(c))
            {
                enfermos.Add(c);
            }
        }

        /// <summary>
        /// Metodo que moviliza a los enfermos.
        /// </summary>
        private void Movilizar()
        {
            if (enfermos.Count == 400)
            {
                return;
            }

            for (int i = 0; i < enfermos.Count; i++)
            {
                dgvPoblacion.Rows[GetY(enfermos[i])].Cells[GetX(enfermos[i])].Style.BackColor = Color.White;
                n = rnd.Next(1, 400);

                if (dgvPoblacion.Rows[GetY(n)].Cells[GetX(n)].Style.BackColor == Color.Green)
                {
                    i--;                   
                }
                else
                {
                    enfermos[i] = n;
                    dgvPoblacion.Rows[GetY(n)].Cells[GetX(n)].Style.BackColor = Color.Green;
                }
            }
        }

        /// <summary>
        /// Limpia la seleccion del data grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvPoblacion.ClearSelection();
        }

        /// <summary>
        /// Cada dos clicks es un ciclo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCiclo_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                Movilizar();
                turn = false;
            }
            else
            {
                Contagiar();
                turn = true;
            }
        }

        /// <summary>
        /// Devuelve el número de enfermos.
        /// </summary>
        /// <returns></returns>
        private int GetEnfermos()
        {
            return enfermos.Count;
        }
    }   
}
