using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_rab
{
    internal class StateTracker
    {
        private readonly Stack<Shape> undoStack = new Stack<Shape>();
        private readonly Stack<Shape> redoStack = new Stack<Shape>();

        public bool CanUndo() => undoStack.Count > 0; 

        public bool CanRedo() => redoStack.Count > 0;

        public void AddToUndo(Shape shape)
        {
            if(CanUndo())
                redoStack.Clear();

            undoStack.Push(shape);
        }

        public void AddToRedo(Shape shape)
        {
            redoStack.Push(shape);
        }

        public Shape Undo()
        {
            if(CanUndo())
            {
                Shape undone = undoStack.Pop();
                return undone;
            }
            return null;
        }

        public Shape Redo()
        {
            if(CanRedo())
            {
                Shape redone = redoStack.Pop();
                return redone;
            }
            return null;
        }

    }
}
