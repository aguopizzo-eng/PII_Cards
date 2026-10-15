//------------------------------------------------------------------------------
// <copyright file="CardSymbolPrinter.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.Cards
{
  /// <summary>
  /// Representa el contenido de una carta usando el símbolo de su palo.
  /// </summary>
  public class CardSymbolPrinter : ICardContent
  {
    private Rank rank;

    private Suit suit;

    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="CardSymbolPrinter"/>.
    /// </summary>
    /// <param name="card">La carta de la que se toman el valor y el palo.</param>
    public CardSymbolPrinter(Card card)
    {
      this.rank = card.Rank;
      this.suit = card.Suit;
    }

    /// <summary>
    /// Obtiene el símbolo correspondiente al palo de la carta.
    /// </summary>
    /// <returns>El símbolo del palo.</returns>
    public string GetSymbol()
    {
      string symbol;
      switch (this.suit)
      {
        case Suit.Hearts:
            symbol = "♥";
            break;
        case Suit.Diamonds:
            symbol = "♦";
            break;
        case Suit.Clubs:
            symbol = "♣";
            break;
        default:
            symbol = "♠";
            break;
      }

      return symbol;
    }

    /// <summary>
    /// Obtiene el texto para imprimir la carta, con el símbolo de su palo.
    /// </summary>
    /// <returns>El texto para imprimir el naipe.</returns>
    public string GetTextToPrint()
    {
      return $" {this.rank} of {this.GetSymbol()}";
    }
  }
}