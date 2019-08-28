using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25Gomoku
{
    class Board
    {

        private static readonly Point NO_MATCH_NODE = new Point(-1, -1);

        private static readonly int OFFSET = 75;
        private static readonly int NODE_RADIUS = 10;
        private static readonly int NODE_DISTRANCE = 75;

        private Piece[,] pieces = new Piece[9, 9];

        public bool CanBePlaced(int x,int y)
        {
            Point nodeID = FindTheCloseNode(x, y);

            if (nodeID == NO_MATCH_NODE)
                return false;

            if (pieces[nodeID.X, nodeID.Y] != null)
                return false;

            return true;
        }

        public Piece PlaceAPiece(int x,int y,PieceType type)
        {
            Point nodeID = FindTheCloseNode(x, y);

            if (nodeID == NO_MATCH_NODE)
                return null;

            if (pieces[nodeID.X, nodeID.Y] != null)
                return null;

            Point formPos = convertToFormPosition(nodeID);
            if (type == PieceType.BLACK)
                pieces[nodeID.X, nodeID.Y] = new BlackPiece(formPos.X, formPos.Y);
            else if (type == PieceType.WHITE)
                pieces[nodeID.X, nodeID.Y] = new WhitePiece(formPos.X, formPos.Y);

            return pieces[nodeID.X, nodeID.Y];
        }

        private Point convertToFormPosition(Point nodeID)
        {
            Point formPositon = new Point();
            formPositon.X = nodeID.X * NODE_DISTRANCE + OFFSET;
            formPositon.Y = nodeID.Y * NODE_DISTRANCE + OFFSET;
            return formPositon;
        }

        private Point FindTheCloseNode(int x, int y)
        {
            int nodelX = FindTheCloseNode(x);
            if (nodelX == -1)
                return NO_MATCH_NODE;

            int nodelY = FindTheCloseNode(y);
            if (nodelY == -1)
                return NO_MATCH_NODE;

            return new Point(nodelX, nodelY);
        }


        private int FindTheCloseNode(int pos)
        {
            if (pos < OFFSET - NODE_RADIUS)
                return -1;

            pos -= OFFSET;
            int quotient = pos / NODE_DISTRANCE;
            int remainder = pos % NODE_DISTRANCE;

            if (remainder <= NODE_RADIUS)
            {
                return quotient;
            }else if(remainder >= NODE_DISTRANCE - NODE_RADIUS)
            {
                return quotient + 1;
            }else
            {
                return -1;
            }
        }
    }
}
