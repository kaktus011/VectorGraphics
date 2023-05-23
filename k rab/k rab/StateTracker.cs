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
        public void AddNewState(Shape shape, bool deleted)
        {
            if (!deleted && shape.CanRedo)
                shape.RedoClear();
            shape.UndoStackPush(shape.GetCopy());
        }

        public Shape Undo(Shape shape)
        {
            Shape undone = shape.UndoStackPop();
            shape.RedoStackPush(undone);
            return undone;
        }

        public Shape Redo(Shape shape)
        {
            Shape redone = shape.RedoStackPop();
            shape.UndoStackPush(redone);
            return redone;
        }
    }
}
