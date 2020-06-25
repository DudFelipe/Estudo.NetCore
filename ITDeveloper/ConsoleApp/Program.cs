using Cooperchip.ITDeveloper.Domain.Enums;
using Cooperchip.ITDeveloper.DomainCore.Extentions;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pacientes = new List<Paciente>
            {
                new Paciente("Maria", 45)
                {
                    TipoEntradaPaciente = TipoEntradaPaciente.Internacao,
                    TipoSaidaPaciente = TipoSaidaPaciente.ARevelia,
                    TipoMovimentoPaciente = TipoMovimentoPaciente.Saida
                },
                
                new Paciente("José", 36)
                {
                    TipoEntradaPaciente = TipoEntradaPaciente.Emergencia,
                    TipoSaidaPaciente = TipoSaidaPaciente.Alta,
                    TipoMovimentoPaciente = TipoMovimentoPaciente.Entrada
                },

                new Paciente("Alícia", 32)
                {
                    TipoEntradaPaciente = TipoEntradaPaciente.SemProntuario,
                    TipoSaidaPaciente = TipoSaidaPaciente.Obito,
                    TipoMovimentoPaciente = TipoMovimentoPaciente.Saida
                },

                new Paciente("Jorge", 26)
                {
                    TipoEntradaPaciente = TipoEntradaPaciente.Transferencia,
                    TipoSaidaPaciente = TipoSaidaPaciente.ARevelia,
                    TipoMovimentoPaciente = TipoMovimentoPaciente.Saida
                }
            };

            Console.WriteLine("Lista de Pacientes - [ SEM ] uso de ExtensionDescription");
            Console.WriteLine();

            foreach(var paciente in pacientes)
            {
                Console.WriteLine($"O Paciente {paciente.Nome} " + 
                                  $"- Idade: {paciente.Idade} " + 
                                  $"- Tipo de Movimento: {paciente.TipoMovimentoPaciente} " + 
                                  $"- TipoEntrada: {paciente.TipoEntradaPaciente} " +
                                  $"- TipoSaida: {paciente.TipoSaidaPaciente} ");
            }

            Console.WriteLine();
            Console.WriteLine("/---------------------/ ------------------------------------------/");
            Console.WriteLine();

            Console.WriteLine("Lista de Pacientes - [ COM ] uso de ExtensionDescription");
            Console.WriteLine();

            foreach (var paciente in pacientes)
            {
                Console.WriteLine($"O Paciente {paciente.Nome} " +
                                  $"- Idade: {paciente.Idade} " +
                                  $"- Tipo de Movimento: {paciente.TipoMovimentoPaciente.ObterDescricao()} " +
                                  $"- TipoEntrada: {paciente.TipoEntradaPaciente.ObterDescricao()} " +
                                  $"- TipoSaida: {paciente.TipoSaidaPaciente.ObterDescricao()} ");
            }

            Console.WriteLine("/---------------------/ ------------------------------------------/");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
