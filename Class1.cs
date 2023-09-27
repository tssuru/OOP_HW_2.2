using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace HW_2._2_oop
{
    abstract class Worker
    {

        public string _name;
        public string _position;
        public string _workDay;


        public void Call()
        {

        }

        public void WriteCode()
        {

        }

        public void Relax()
        {

        }
        public abstract void FillWorkDay();
    }

    class Developer : Worker
    {
        public Developer(string name, string position, string day)
        {
            _position = position;
            _name = name;
            _workDay= day;
        }

        public override void FillWorkDay()
        {
            WriteCode();
            Call();
            Relax();
            WriteCode();
        }
    }

    class Manager : Worker
    {
        private Random _random;

        public Manager(string name, string position, string day)
        {
            _position = position;
            _name = name;
            _workDay = day;
        }
    
        public override void FillWorkDay()
        {
            for (int i = 0; i < _random.NextInt64(10) + 1; i++)
            {
                Call();
            }

            Relax();

            for (int i = 0; i < _random.NextInt64(5) + 1; i++)
            {
                Call();
            }
        }

    }

    class Team
    {
        private string _teamName;
        private List<Worker> _workers = new List<Worker>();
        public Team(string teamName)
        {
            _teamName = teamName;
        }

        public void AddWorker(Worker worker)
        {
            _workers.Add(worker);
        }

        public void WatchInf()
        {
            Console.WriteLine(_teamName);
            foreach (Worker worker in _workers)
            {
                Console.WriteLine(worker._name);
            }
        }

        public void GetDetailInf()
        {
            Console.WriteLine(_teamName);
            foreach (Worker worker in _workers)
            {
                Console.WriteLine($"<{worker._name}> - <{worker._position}> - <{worker._workDay}>");                
            }
        }
    }
}

