namespace Practica2.Patrones.Decorator
{
    public class DecoradorAntiguedad : DecoradorSuscriptor
    {
        public DecoradorAntiguedad(IMostrable componente) : base(componente) { }

        public override string mostrarInfo()
        {
            var s = getSuscriptor();
            return $"{s.getNombre()} (Suscriptor hace {s.getMesesDeSuscripcion()} meses) {s.getHorasVistas()} horas vistas";
        }
    }

    public class DecoradorFanatico : DecoradorSuscriptor
    {
        public DecoradorFanatico(IMostrable componente) : base(componente) { }

        public override string mostrarInfo()
        {
            var s = getSuscriptor();
            string nivel = "Bronce";
            if (s.getHorasVistas() >= 50) nivel = "Oro";
            else if (s.getHorasVistas() >= 10) nivel = "Plata";

            return $"[{nivel}] {componente.mostrarInfo()}";
        }
    }

    public class DecoradorEstadoCuenta : DecoradorSuscriptor
    {
        public DecoradorEstadoCuenta(IMostrable componente) : base(componente) { }

        public override string mostrarInfo()
        {
            var s = getSuscriptor();
            string estado = s.getHorasVistas() > 0 ? "Cuenta Activa" : "Cuenta Inactiva";
            return $"{s.getNombre()} ({estado}) {s.getHorasVistas()} horas vistas";
        }
    }

    public class DecoradorRecuadro : DecoradorSuscriptor
    {
        public DecoradorRecuadro(IMostrable componente) : base(componente) { }

        public override string mostrarInfo()
        {
            string info = componente.mostrarInfo();
            string marco = new string('*', info.Length + 4);
            return $"{marco}\n* {info} *\n{marco}";
        }
    }
}