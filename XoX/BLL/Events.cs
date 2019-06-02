using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public delegate void xoxGameHandler(Game game);
    public delegate void xoxGameOverHandler(Game game, List<List<int>> winningConditions);
    public class Events
    {
    }
}
