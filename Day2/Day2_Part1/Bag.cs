using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Part1
{
    public class Bag
    {
        private List<Cube> cubes;
        private int id;

        public Bag(int id, List<Cube>? cubesList)
        {
            this.id = id;

            if(cubesList is null)
            {
                this.cubes = new List<Cube>();
            }
            else
            {
                this.cubes = cubesList;
            }
            
        }

        public List<Cube> Cubes
        {
            get
            {
                return this.cubes;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public void AddCube(Cube cube)
        {
            this.cubes.Add(cube);
        }

        public void AddCubes(List<Cube> cubesList)
        {
            this.cubes = cubesList;
        }
    }
}
