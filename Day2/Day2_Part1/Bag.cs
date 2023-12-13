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

        public Bag(List<Cube>? cubesList)
        {
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
