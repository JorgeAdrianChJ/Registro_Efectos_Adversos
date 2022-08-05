using System;
using System.Collections.Generic;

namespace Registro_Efectos_Adversos.Models
{
    public partial class Solicitud
    {
        public int Id { get; set; }
        public int? IdMedico { get; set; }
        public int? IdClinica { get; set; }
        public int? IdPaciente { get; set; }
        public int? IdVacuna { get; set; }
        public bool? Respuesta1 { get; set; }
        public bool? Respuesta2 { get; set; }
        public bool? Respuesta3 { get; set; }
        public bool? Respuesta4 { get; set; }
        public bool? Respuesta5 { get; set; }
        public bool? Respuesta6 { get; set; }
        public bool? Respuesta7 { get; set; }
        public bool? Respuesta8 { get; set; }
        public bool? Respuesta9 { get; set; }
        public bool? Respuesta10 { get; set; }
        public string? Respuesta11 { get; set; }
        public bool? Respuesta12 { get; set; }
        public bool? Respuesta13 { get; set; }
        public bool? Respuesta14 { get; set; }
        public bool? Respuesta15 { get; set; }
        public bool? Respuesta16 { get; set; }
        public string? Respuesta17 { get; set; }
        public bool? Respuesta18 { get; set; }
        public bool? Respuesta19 { get; set; }
        public bool? Respuesta21 { get; set; }
        public bool? Respuesta22 { get; set; }
        public bool? Respuesta23 { get; set; }
        public bool? Respuesta24 { get; set; }
        public bool? Respuesta25 { get; set; }
        public bool? Respuesta26 { get; set; }
        public bool? Respuesta27 { get; set; }
        public bool? Respuesta28 { get; set; }
        public bool? Respuesta29 { get; set; }
        public bool? Respuesta30 { get; set; }
        public bool? Respuesta31 { get; set; }
        public bool? Respuesta32 { get; set; }
        public bool? Respuesta33 { get; set; }
        public bool? Respuesta34 { get; set; }
        public bool? Respuesta35 { get; set; }
        public bool? Respuesta36 { get; set; }
        public bool? Respuesta37 { get; set; }
        public bool? Respuesta38 { get; set; }
        public bool? Respuesta39 { get; set; }
        public bool? Respuesta40 { get; set; }
        public bool? Respuesta41 { get; set; }
        public bool? Respuesta42 { get; set; }
        public bool? Respuesta43 { get; set; }
        public bool? Respuesta44 { get; set; }
        public bool? Respuesta45 { get; set; }
        public bool? Respuesta46 { get; set; }
        public bool? Respuesta47 { get; set; }
        public bool? Respuesta48 { get; set; }
        public bool? Respuesta49 { get; set; }
        public bool? Respuesta50 { get; set; }
        public bool? Respuesta51 { get; set; }
        public bool? Respuesta52 { get; set; }
        public bool? Respuesta53 { get; set; }
        public bool? Respuesta54 { get; set; }
        public bool? Respuesta55 { get; set; }
        public bool? Respuesta56 { get; set; }
        public bool? Respuesta57 { get; set; }
        public bool? Respuesta58 { get; set; }
        public bool? Respuesta59 { get; set; }
        public bool? Respuesta60 { get; set; }
        public bool? Respuesta61 { get; set; }
        public bool? Respuesta62 { get; set; }
        public bool? Respuesta63 { get; set; }
        public bool? Respuesta64 { get; set; }
        public string? Respuesta65 { get; set; }
        public string? Respuesta66 { get; set; }
        public bool? Respuesta67 { get; set; }
        public bool? Respuesta68 { get; set; }
        public bool? Respuesta69 { get; set; }
        public bool? Respuesta70 { get; set; }
        public bool? Respuesta71 { get; set; }
        public bool? Respuesta72 { get; set; }
        public bool? Respuesta73 { get; set; }
        public bool? Respuesta74 { get; set; }
        public bool? Respuesta75 { get; set; }
        public bool? Respuesta76 { get; set; }
        public bool? Respuesta77 { get; set; }
        public bool? Respuesta78 { get; set; }
        public bool? Respuesta79 { get; set; }
        public bool? Respuesta80 { get; set; }
        public bool? Respuesta81 { get; set; }
        public bool? Respuesta82 { get; set; }
        public bool? Respuesta83 { get; set; }
        public bool? Respuesta84 { get; set; }
        public bool? Respuesta85 { get; set; }
        public bool? Respuesta86 { get; set; }
        public bool? Respuesta87 { get; set; }
        public bool? Respuesta88 { get; set; }
        public bool? Respuesta89 { get; set; }

        public virtual Clinica? IdClinicaNavigation { get; set; }
        public virtual Medico? IdMedicoNavigation { get; set; }
        public virtual Paciente? IdPacienteNavigation { get; set; }
        public virtual Vacuna? IdVacunaNavigation { get; set; }
    }
}
