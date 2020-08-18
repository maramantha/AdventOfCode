using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2019
{
    class Day8SpaceImageFormat
    {
        string[,] Layers;
        private int _output;
        public int Output
        {
            get { return _output; }
        }
        private void fillInLayers(ref string[,] layer, string input, int width, int height)
        {
            string[] LayeredInput = new string[input.Length / (width * height)];
            for(int i = 0; i<LayeredInput.Length;i++)
            {
                LayeredInput[i] = input.Substring(i * width * height, width * height);
            }

            for(int i = 0; i <LayeredInput.Length;i++)
            {
                for(int j = 0; j < height;j++)
                {
                    layer[i, j] = LayeredInput[i].Substring(j * width, width);
                }
            }

        }
        private int CharCounter(string arrElement,char MatchingChar)
        {
            int temp = 0;
            for(int i = 0; i<arrElement.Length; i++)
            {
                if(arrElement[i].Equals(MatchingChar))
                {
                    temp++;
                }
            }
            return temp;
        }
        private int findLine(ref string[,] layer)
        {
            int tempLayer = 0;
            int temp = 0;
            int tempcompare = int.MaxValue;
            for(int i = 0; i < layer.GetLength(0); i++)
            {
                for(int j = 0; j < (layer.Length/layer.GetLength(0));j++)
                {
                    temp += CharCounter(layer[i, j],'0');
                }
                if(tempcompare > temp)
                {
                    tempcompare = temp;
                    tempLayer = i;
                }
                temp = 0;
            }
            return tempLayer;
        }
        private string ItemFromLayer(char CharFactor, int layer, int j, int a)
        {
            switch(CharFactor)
            {
                case '1':
                    return "1";
                case '2':
                    return ItemFromLayer(Layers[layer + 1, j][a], layer + 1, j, a);
                case '0':
                    return "0";
            }
            return "Hello";

        }
        public string[] FindMessage()
        {
            int alph = Layers.GetLength(0);
            string Output ="";
            string[] OutputVal = new string[(Layers.Length / Layers.GetLength(0))];
                for(int j = 0; j < (Layers.Length / Layers.GetLength(0)); j++)
                {
                    for(int a = 0; a < Layers[0,j].Length;a++)
                    {
                    Output += ItemFromLayer(Layers[0, j][a],0,j,a);
                    }
                OutputVal[j] = Output;
                Output = "";
                }
            return OutputVal;
        }
        public Day8SpaceImageFormat(int width, int height, string input)
        {
            Layers = new string[input.Length/(width* height),(input.Length/(input.Length/(width*height)))/width];
            fillInLayers(ref Layers, input,width,height);
            int layerValue = findLine(ref Layers);
            int output = 0;
            int a = 0;
            int b = 0;
            for (int i = 0;  i < height; i++)
            {
                a += CharCounter(Layers[layerValue, i], '1');
                b += CharCounter(Layers[layerValue, i], '2');
            }
            output = a * b;
            _output = output;
        }
    }
}
