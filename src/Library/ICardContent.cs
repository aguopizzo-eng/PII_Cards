//------------------------------------------------------------------------------
// <copyright file="ICardContent.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.Cards
{
    /// <summary>
    /// Representa el contenido de una carta.
    /// </summary>
    public interface ICardContent
    {
        /// <summary>
        /// Obtiene el texto para imprimir el contenido de la carta.
        /// </summary>
        /// <returns>El texto para imprimir el naipe.</returns>
        string GetTextToPrint();
    }
}
