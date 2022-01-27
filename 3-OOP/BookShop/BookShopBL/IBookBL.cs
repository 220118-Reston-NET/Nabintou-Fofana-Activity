using BookModel;

namespace BooksBL
{
    /// <summary>
    /// Business Layer is responsible for further validation or processing of data obtained from either the database or the user
    /// What kind of processing? That all depends on the type of functionality you will be doing
    /// </summary>
    public interface IBookBL
    {
        /// <summary>
        /// Will add a pokemon data to the database
        /// Initial addition of a pokemon will give it some sort of a randomize stats
        /// Can only have the total of 4 pokemons in the database
        /// </summary>
        /// <param name="b_book"></param>
        /// <returns></returns>
        Pokemon AddBook(Pokemon b_book);
    }
}