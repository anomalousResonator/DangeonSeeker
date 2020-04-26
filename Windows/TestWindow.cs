using System.Collections.Generic;
using System;

namespace AbyssBehavior{
    class TestWindow:Window{
        protected override void Initialization(){
            transform.SetupScale(new Vector(31,10));//установить размер окна
            logic = new TestLogic(this);//Заменить на свою логику
            //AddWidget("instruction", new TextBox(new Vector(0,0), new Vector(40,1), ""))
            //AddWidget("counter", new TextBox(new Vector(3,1), new Vector(10,1), "0", this), false);
            AddMenu("info", new TextBox(new Vector(0,0), new Vector(30,1)), "this is menu list with counter");
            AddWidget("info2", new TextBox(new Vector(0,1), new Vector(31,1)), "press a for minus or d for plus");
            AddMenu("counter", new TextBox(new Vector(10,2), new Vector(2,1)), "0");
            AddMenu("counter2", new TextBox(new Vector(0,3), new Vector(13,1)), "menu number 2");
            AddMenu("counter3", new TextBox(new Vector(0,4), new Vector(13,1)), "menu number 3");
            
        }

        protected override void PostInitialization(){
            string[,] testCanvas = {{"UL","U","U","U","U","U","U","U","U","U","U","U","U","U","U","U","U","U","U","U","U","U","U","U","U","U","U","U","U","U","UR"},
                                    {"L","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","R"},
                                    {"L","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","R"},
                                    {"L","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","R"},
                                    {"L","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","R"},
                                    {"L","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","R"},
                                    {"L","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","R"},
                                    {"L","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","R"},
                                    {"L","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","F","R"},
                                    {"DL","D","D","D","D","D","D","D","D","D","D","D","D","D","D","D","D","D","D","D","D","D","D","D","D","D","D","D","D","D","DR"}};
            canvas.LoadCanvas(testCanvas);
        }
    }
}