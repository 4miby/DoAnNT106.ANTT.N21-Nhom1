using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocaro.Class
{
    [Serializable]
    public class SocketData
    {
        private int command;
        private Point point;
        private String message;

        public int Command { get => command; set => command = value; }
        public Point Point { get => point; set => point = value; }
        public string Message { get => message; set => message = value; }
        public SocketData(int command, String message, Point point) 
        {
            this.Command = command;
            this.Point = point;
            this.Message = message;
        }
        public enum SocketCommand
        {
            SEND_POINT,
            NOTIFY,
            NEW_GAME,
            QUIT,
        }
    }
}
