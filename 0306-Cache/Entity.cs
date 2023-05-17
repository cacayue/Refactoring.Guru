using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0306_Cache
{
    public  class TreeType
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public string Texture { get; set; }

        public TreeType(string name, string color, string texture)
        {
            Name = name;
            Color = color;
            Texture = texture;
        }

        public void Draw(string canvas, int x, int y)
        {
            Console.WriteLine($"type={Name}{Color}{Texture}, Draw {canvas} -- point -- {x} - {y}");
        }
    }

    public class Tree
    {
        // 外在状态
        public int X { get; set; }

        public int Y { get; set; }

        // 内在状态
        public TreeType TreeType { get; set; }

        public Tree(int x, int y, TreeType treeType)
        {
            X = x;
            Y = y;
            TreeType = treeType;
        }

        public void Draw(string canvas)
        {
            TreeType.Draw(canvas, X, Y);
        }
    }

    public class Forest
    {
        public List<Tree> Trees { get; set; } = new List<Tree>();

        public Tree PlantTree(int x, int y, string name, string color, string texture)
        {
            var treeType = TreeFactory.GetTreeType(name, color, texture);

            var tree = new Tree(x, y, treeType);

            Trees.Add(tree);
            
            return tree;
        }

        public void Draw(string canvas)
        {
            foreach (var tree in Trees)
            {
                tree.Draw(canvas);
            }
        }
    }

    public static class TreeFactory
    {
        public static List<TreeType> TreeTypes { private get; set; } = new List<TreeType>();
    
        public static TreeType GetTreeType(string name, string color, string texture)
        {
            // 重复使用内在状态
            var treeType = TreeTypes.FirstOrDefault(x => x.Name == name
            && x.Color == color && x.Texture == texture);

            if (treeType == null)
            {
                var newTreeType = new TreeType(name, color, texture);
                TreeTypes.Add(newTreeType);
                return newTreeType;
            }
            else
            {
                return treeType;
            }
        }
    }
}
