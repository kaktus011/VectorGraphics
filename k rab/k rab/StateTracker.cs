using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace k_rab
{
    internal class StateTracker
    {

        public void AddNewState(Shape shape)
        {
            shape.RedoClear();
            shape.UndoStackPush(shape.GetCopy());
        }

        public Shape Undo(Shape shape)
        {
            //if(shape.CanUndo)
            //{
                Shape undone = shape.UndoStackPop();
                shape.RedoStackPush(undone);
                return undone;
            //}
            //return null;
        }

        public Shape Redo(Shape shape)
        {
            if(shape.CanRedo)
            {
                Shape redone = shape.RedoStackPop();
                return redone;
            }
            return null; 
        }

    }
}
