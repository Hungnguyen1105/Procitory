using asm2_1651;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Asm2_1651
{
    internal class Class1
    {
        public static void Main(string[] args)
        {
            AbstractFactoryPrint factoryOffice = null;
            AbstractPrint printer = null;
            AbstractCopy coppy = null;
            List<AbstractPrint> printerList = new List<AbstractPrint>();
            List<AbstractCopy> coppyList = new List<AbstractCopy>();
            bool exit = false;
            int update = 0;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("+--------------------------------------------+");
                Console.WriteLine("|                  Company VH                |");
                Console.WriteLine("+--------------------------------------------+");
                Console.WriteLine("| 1. Create new product                      |");
                Console.WriteLine("| 2. Information product                     |");
                Console.WriteLine("| 3. Edit product office                     |");
                Console.WriteLine("| 4. Delete product                          |");
                Console.WriteLine("| 5. Action                                  |");
                Console.WriteLine("| 6. Exit                                    |");
                Console.WriteLine("+--------------------------------------------+");
                Console.WriteLine("");
                Console.WriteLine("Please choose one");
                int choiceMenu1;
                try
                {
                    choiceMenu1 = int.Parse(Console.ReadLine());

                    switch (choiceMenu1)
                    {
                        case 1:
                            bool backToLevel1 = false;

                            while (!backToLevel1)
                            {
                                Console.Clear();
                                Console.WriteLine("+--------------------------------------------+");
                                Console.WriteLine("|           Feature will your choice         |");
                                Console.WriteLine("+--------------------------------------------+");
                                Console.WriteLine("| 1. Single                                  |");
                                Console.WriteLine("| 2. Multifunction                           |");
                                Console.WriteLine("| 3. Back                                    |");
                                Console.WriteLine("+--------------------------------------------+");
                                Console.WriteLine("");
                                Console.WriteLine("Please choose one");
                                int choiceMenu2;
                                try
                                {
                                    choiceMenu2 = int.Parse(Console.ReadLine());

                                    switch (choiceMenu2)
                                    {
                                        case 1:
                                            //logic
                                            factoryOffice = new SinglePrintFactory();
                                            //
                                            bool backToLevel2 = false;
                                            while (!backToLevel2)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("+--------------------------------------------+");
                                                Console.WriteLine("|        The type of machine you choose      |");
                                                Console.WriteLine("+--------------------------------------------+");
                                                Console.WriteLine("| 1. Copy                                    |");
                                                Console.WriteLine("| 2. Print                                   |");
                                                Console.WriteLine("| 3. Back                                    |");
                                                Console.WriteLine("+--------------------------------------------+");
                                                Console.WriteLine("");
                                                Console.WriteLine("Please choose one");
                                                int choiceMenu3;
                                                try
                                                {
                                                    choiceMenu3 = int.Parse(Console.ReadLine());

                                                    switch (choiceMenu3)
                                                    {
                                                        case 1:
                                                            //logic
                                                            coppy = factoryOffice.CreateCopy();
                                                            coppy.Name = "Copy";
                                                            coppy.Feature = "Single";
                                                            coppyList.Add(coppy);
                                                            createNotification();
                                                            backToLevel2 = true;
                                                            backToLevel1 = true;
                                                            //
                                                            break;
                                                        case 2:
                                                            //logic
                                                            printer = factoryOffice.CreatePrint();
                                                            printer.Name = "Print";
                                                            printer.Feature = "Single";
                                                            printerList.Add(printer);
                                                            createNotification();
                                                            backToLevel2 = true;
                                                            backToLevel1 = true;
                                                            //
                                                            break;
                                                        case 3:
                                                            backToLevel2 = true;
                                                            break;
                                                        default:
                                                            invalidNotification();
                                                            break;
                                                    }
                                                }
                                                catch (System.Exception e)
                                                {
                                                    invalidNotification();
                                                }
                                            }
                                            break;
                                        case 2:
                                            //logic
                                            factoryOffice = new MultifunctionPrintFactory();
                                            //
                                            bool backToLevel2_1 = false;
                                            while (!backToLevel2_1)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("+--------------------------------------------+");
                                                Console.WriteLine("|        The type of machine you choose      |");
                                                Console.WriteLine("+--------------------------------------------+");
                                                Console.WriteLine("| 1. Copy                                    |");
                                                Console.WriteLine("| 2. Print                                   |");
                                                Console.WriteLine("| 3. Back                                    |");
                                                Console.WriteLine("+--------------------------------------------+");
                                                Console.WriteLine("");
                                                Console.WriteLine("Please choose one");
                                                int choiceMenu3;
                                                try
                                                {
                                                    choiceMenu3 = int.Parse(Console.ReadLine());

                                                    switch (choiceMenu3)
                                                    {
                                                        case 1:
                                                            //logic
                                                            coppy = factoryOffice.CreateCopy();
                                                            coppy.Name = "Copy";
                                                            coppy.Feature = "Multifunction";
                                                            coppyList.Add(coppy);
                                                            createNotification();
                                                            backToLevel2_1 = true;
                                                            backToLevel1 = true;
                                                            //
                                                            break;
                                                        case 2:
                                                            //logic
                                                            printer = factoryOffice.CreatePrint();
                                                            printer.Name = "Print";
                                                            printer.Feature = "Multifunction";
                                                            printerList.Add(printer);
                                                            createNotification();
                                                            backToLevel2_1 = true;
                                                            backToLevel1 = true;
                                                            //
                                                            break;
                                                        case 3:
                                                            backToLevel2_1 = true;
                                                            break;
                                                        default:
                                                            invalidNotification();
                                                            break;
                                                    }
                                                }
                                                catch (System.Exception e)
                                                {
                                                    invalidNotification();
                                                }
                                            }
                                            break;
                                        case 3:
                                            backToLevel1 = true;
                                            break;
                                        default:
                                            invalidNotification();
                                            break;
                                    }
                                }
                                catch (System.Exception e)
                                {
                                    invalidNotification();
                                }
                            }
                            break;
                        case 2:
                            productList();
                            Console.ReadLine();
                            break;
                        case 3:
                            productList();
                            Console.WriteLine("Choose the product you want to edit:");
                            int choiceUpdate;
                            try
                            {
                                choiceUpdate = int.Parse(Console.ReadLine());

                                //logic choose the product list
                                bool CopyChoice = false;
                                bool PrintChoice = false;
                                // chose and choice
                                int choseUpdate = (choiceUpdate - 1);
                                if (choseUpdate < coppyList.Count)
                                {
                                    for (int i = 0; i < coppyList.Count; i++)
                                    {
                                        if (choseUpdate == i)
                                        {
                                            CopyChoice = true;
                                            update = i;
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    choseUpdate = choseUpdate - coppyList.Count;
                                    for (int i = 0; i < printerList.Count; i++)
                                    {
                                        if (choseUpdate == i)
                                        {
                                            PrintChoice = true;
                                            update = i;
                                            break;
                                        }
                                    }
                                }
                                if (CopyChoice)
                                {
                                    
                                    bool update_while = false;
                                    while (!update_while)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("+--------------------------------------------+");
                                        Console.WriteLine("|                    Update - Copy           |");
                                        Console.WriteLine("+--------------------------------------------+");
                                        Console.WriteLine("| 1. Update Paper                            |");
                                        Console.WriteLine("| 2. Update Color                            |");
                                        Console.WriteLine("| 3. Back                                    |");
                                        Console.WriteLine("+--------------------------------------------+");
                                        Console.WriteLine("");
                                        Console.WriteLine("Please choose one");
                                        int choiceUpdateItem;
                                        try
                                        {
                                            choiceUpdateItem = int.Parse(Console.ReadLine());
                                            switch (choiceUpdateItem)
                                            {
                                                case 1:
                                                    bool update_paper = false;
                                                    while (!update_paper)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("|            Update choose your Paper        |");
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("| 1. 60 paper                                |");
                                                        Console.WriteLine("| 2. 80 paper                                |");
                                                        Console.WriteLine("| 3. 100 paper                               |");
                                                        Console.WriteLine("| 4. Back                                    |");
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("");
                                                        Console.WriteLine("Please choose one");
                                                        int FeatureToolEdit = 0;
                                                        try
                                                        {
                                                            FeatureToolEdit = int.Parse(Console.ReadLine());

                                                            switch (FeatureToolEdit)
                                                            {
                                                                case 1:
                                                                    coppyList[update].Paper = 60;
                                                                    update_paper = true;
                                                                    update_while = true;
                                                                    updateNotification();
                                                                    break;
                                                                case 2:
                                                                    coppyList[update].Paper = 80;
                                                                    update_paper = true;
                                                                    update_while = true;
                                                                    updateNotification();
                                                                    break;
                                                                case 3:
                                                                    coppyList[update].Paper = 100;
                                                                    update_paper = true;
                                                                    update_while = true;
                                                                    updateNotification();
                                                                    break;
                                                                case 4:
                                                                    update_paper = true;
                                                                    break;
                                                                default:
                                                                    invalidNotification();
                                                                    break;
                                                            }
                                                        }
                                                        catch (System.Exception e)
                                                        {
                                                            invalidNotification();
                                                        }
                                                    }
                                                    break;
                                                case 2:
                                                    
                                                        bool update_status = false;
                                                        while (!update_status)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("|                  Update Color              |");
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("| 1. Blue                                    |");
                                                            Console.WriteLine("| 2. Red                                     |");
                                                            Console.WriteLine("| 3. Green                                   |");
                                                            Console.WriteLine("| 4. Black and White                         |");
                                                            Console.WriteLine("| 5. Exit                                    |");
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("Please choose one");
                                                            int UpdateStatus;
                                                            try
                                                            {
                                                                UpdateStatus = int.Parse(Console.ReadLine());

                                                            switch (UpdateStatus)
                                                            {
                                                                case 1:
                                                                    if (coppyList[update].Feature == "Single")
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("Invalid");
                                                                        Console.ReadLine();
                                                                    }
                                                                    if (coppyList[update].Feature == "Multifunction")
                                                                    {
                                                                        coppyList[update].Color = "Blue";
                                                                        update_status = true;
                                                                        update_while = true;
                                                                        updateNotification();
                                                                    }
                                                                    break;
                                                                case 2:
                                                                    if (coppyList[update].Feature == "Single")
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("Invalid");
                                                                        Console.ReadLine();
                                                                    }
                                                                    if (coppyList[update].Feature == "Multifunction")
                                                                    { 
                                                                    coppyList[update].Color = "Red";
                                                                    update_status = true;
                                                                    update_while = true;
                                                                    updateNotification();
                                                                    }
                                                                    break;

                                                                    case 3:
                                                                    if (coppyList[update].Feature == "Single")
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("Invalid");
                                                                        Console.ReadLine();
                                                                    }
                                                                    if (coppyList[update].Feature == "Multifunction")
                                                                    {
                                                                        coppyList[update].Color = "Green";
                                                                        update_status = true;
                                                                        update_while = true;
                                                                        updateNotification();
                                                                    }
                                                                    break;
                                                                    case 4:
                                                                    if (coppyList[update].Feature == "Single")
                                                                    {
                                                                        Console.Clear();
                                                                        coppyList[update].Color = "Black and White";
                                                                        update_status = true;
                                                                        update_while = true;                                                                
                                                                        updateNotification();
                                                                    }
                                                                    if (coppyList[update].Feature == "Multifunction")
                                                                    {
                                                                        coppyList[update].Color = "Black and White";
                                                                        update_status = true;
                                                                        update_while = true;
                                                                        updateNotification();
                                                                    }
                                                                    break;
                                                                    case 5:
                                                                        update_status = true;
                                                                        break;
                                                                    default:
                                                                        invalidNotification();
                                                                        break;
                                                                }
                                                            }
                                                            catch (System.Exception e)
                                                            {
                                                                invalidNotification();
                                                            }
                                                        }                                                                                                 
                                                    break;                                             
                                                case 3:
                                                    update_while = true;
                                                    break;
                                                default:
                                                    invalidNotification();
                                                    break;
                                            }
                                        }
                                        catch (System.Exception e)
                                        {
                                            invalidNotification();
                                        }
                                    }

                                }

                                else if (PrintChoice)
                                {
                                    bool update_while = false;
                                    while (!update_while)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("+--------------------------------------------+");
                                        Console.WriteLine("|                    Update - Copy           |");
                                        Console.WriteLine("+--------------------------------------------+");
                                        Console.WriteLine("| 1. Update Paper                            |");
                                        Console.WriteLine("| 2. Update Color                            |");
                                        Console.WriteLine("| 3. Back                                    |");
                                        Console.WriteLine("+--------------------------------------------+");
                                        Console.WriteLine("");
                                        Console.WriteLine("Please choose one");
                                        int choiceUpdateItem;
                                        try
                                        {
                                            choiceUpdateItem = int.Parse(Console.ReadLine());
                                            switch (choiceUpdateItem)
                                            {
                                                case 1:
                                                    bool update_paper = false;
                                                    while (!update_paper)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("|            Update choose your Paper        |");
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("| 1. 60 paper                                |");
                                                        Console.WriteLine("| 2. 80 paper                                |");
                                                        Console.WriteLine("| 3. 100 paper                               |");
                                                        Console.WriteLine("| 4. Back                                    |");
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("");
                                                        Console.WriteLine("Please choose one");
                                                        int FeatureToolEdit = 0;
                                                        try
                                                        {
                                                            FeatureToolEdit = int.Parse(Console.ReadLine());

                                                            switch (FeatureToolEdit)
                                                            {
                                                                case 1:
                                                                    printerList[update].Paper = 60;
                                                                    update_paper = true;
                                                                    update_while = true;
                                                                    updateNotification();
                                                                    break;
                                                                case 2:
                                                                    printerList[update].Paper = 80;
                                                                    update_paper = true;
                                                                    update_while = true;
                                                                    updateNotification();
                                                                    break;
                                                                case 3:
                                                                    printerList[update].Paper = 100;
                                                                    update_paper = true;
                                                                    update_while = true;
                                                                    updateNotification();
                                                                    break;
                                                                case 4:
                                                                    update_paper = true;
                                                                    break;
                                                                default:
                                                                    invalidNotification();
                                                                    break;
                                                            }
                                                        }
                                                        catch (System.Exception e)
                                                        {
                                                            invalidNotification();
                                                        }
                                                    }
                                                    break;
                                                case 2:

                                                    bool update_status = false;
                                                    while (!update_status)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("|                  Update Color              |");
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("| 1. Blue                                    |");
                                                        Console.WriteLine("| 2. Red                                     |");
                                                        Console.WriteLine("| 3. Green                                   |");
                                                        Console.WriteLine("| 4. Black and White                         |");
                                                        Console.WriteLine("| 5. Exit                                    |");
                                                        Console.WriteLine("+--------------------------------------------+");
                                                        Console.WriteLine("");
                                                        Console.WriteLine("Please choose one");
                                                        int UpdateStatus;
                                                        try
                                                        {
                                                            UpdateStatus = int.Parse(Console.ReadLine());

                                                            switch (UpdateStatus)
                                                            {
                                                                case 1:
                                                                    if (printerList[update].Feature == "Single")
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("Invalid");
                                                                        Console.ReadLine();
                                                                    }
                                                                    if (printerList[update].Feature == "Multifunction")
                                                                    {
                                                                        printerList[update].Color = "Blue";
                                                                        update_status = true;
                                                                        update_while = true;
                                                                        updateNotification();
                                                                    }
                                                                    break;
                                                                case 2:
                                                                    if (printerList[update].Feature == "Single")
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("Invalid");
                                                                        Console.ReadLine();
                                                                    }
                                                                    if (printerList[update].Feature == "Multifunction")
                                                                    {
                                                                        printerList[update].Color = "Red";
                                                                        update_status = true;
                                                                        update_while = true;
                                                                        updateNotification();
                                                                    }
                                                                    break;

                                                                case 3:
                                                                    if (printerList[update].Feature == "Single")
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("Invalid");
                                                                        Console.ReadLine();
                                                                    }
                                                                    if (printerList[update].Feature == "Multifunction")
                                                                    {
                                                                        printerList[update].Color = "Green";
                                                                        update_status = true;
                                                                        update_while = true;
                                                                        updateNotification();
                                                                    }
                                                                    break;
                                                                case 4:
                                                                    if (printerList[update].Feature == "Single")
                                                                    {
                                                                        Console.Clear();
                                                                        printerList[update].Color = "Black and White";
                                                                        update_status = true;
                                                                        update_while = true;
                                                                        updateNotification() ;
                                                                        
                                                                    }
                                                                    if (printerList[update].Feature == "Multifunction")
                                                                    {
                                                                        printerList[update].Color = "Black and White";
                                                                        update_status = true;
                                                                        update_while = true;
                                                                        updateNotification();
                                                                    }
                                                                    break;
                                                                case 5:
                                                                    update_status = true;
                                                                    break;
                                                                default:
                                                                    invalidNotification();
                                                                    break;
                                                            }
                                                        }
                                                        catch (System.Exception e)
                                                        {
                                                            invalidNotification();
                                                        }
                                                    }
                                                    break;
                                                case 3:
                                                    update_while = true;
                                                    break;
                                                default:
                                                    invalidNotification();
                                                    break;
                                            }
                                        }
                                        catch (System.Exception e)
                                        {
                                            invalidNotification();
                                        }
                                    }
                                }
                                else
                                {
                                    invalidNotification();
                                }
                            }
                            catch (System.Exception e)
                            {
                                invalidNotification();
                            }
                            break;
                        case 4:
                            productList();
                            Console.WriteLine("Choose the product you want to delete:");
                            int choiceDelete;
                            try
                            {
                                choiceDelete = int.Parse(Console.ReadLine());

                                bool CopyChoice = false;
                                bool PrintChoice = false;
                                // chose and choice
                                int choseUpdate = (choiceDelete - 1);
                                if (choseUpdate < coppyList.Count)
                                {
                                    for (int i = 0; i < coppyList.Count; i++)
                                    {
                                        if (choseUpdate == i)
                                        {
                                            CopyChoice = true;
                                            update = i;
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    choseUpdate = choseUpdate - coppyList.Count;
                                    for (int i = 0; i < printerList.Count; i++)
                                    {
                                        if (choseUpdate == i)
                                        {
                                            PrintChoice = true;
                                            update = i;
                                            break;
                                        }
                                    }
                                }
                                if (CopyChoice)
                                {
                                    coppyList.Remove(coppyList[update]);
                                    deleteNotification();
                                }
                                if (PrintChoice)
                                {
                                    printerList.Remove(printerList[update]);
                                    deleteNotification();
                                }
                            }
                            catch (System.Exception e)
                            {
                                invalidNotification();
                            }
                            break;                     
                        case 5:
                            productList();
                            Console.WriteLine("Choose the product you want to test:");
                            int choiceAction;
                            try
                            {
                                choiceAction = int.Parse(Console.ReadLine());

                                bool CopyChoice = false;
                                bool PrintChoice = false;
                                // chose and choice
                                int choseUpdate = (choiceAction - 1);
                                if (choseUpdate < coppyList.Count)
                                {
                                    for (int i = 0; i < coppyList.Count; i++)
                                    {
                                        if (choseUpdate == i)
                                        {
                                            CopyChoice = true;
                                            update = i;
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    choseUpdate = choseUpdate - coppyList.Count;
                                    for (int i = 0; i < printerList.Count; i++)
                                    {
                                        if (choseUpdate == i)
                                        {
                                            PrintChoice = true;
                                            update = i;
                                            break;
                                        }
                                    }
                                }
                                if (CopyChoice)
                                {
                                    if (!string.IsNullOrEmpty(coppyList[update].Paper.ToString()))
                                    {
                                        bool CopyTest = false;
                                        while (!CopyTest)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("+--------------------------------------------+");
                                            Console.WriteLine("|                   TESTING                  |");
                                            Console.WriteLine("+--------------------------------------------+");
                                            Console.WriteLine("| 1. Time to scan documents                  |");
                                            Console.WriteLine("| 2. Document copy time.                     |");
                                            Console.WriteLine("| 3. Fax document.                           |");
                                            Console.WriteLine("| 4. Back                                    |");
                                            Console.WriteLine("+--------------------------------------------+");
                                            Console.WriteLine("");
                                            Console.WriteLine("Please choose one");
                                            int testing;
                                            try
                                            {
                                                testing = int.Parse(Console.ReadLine());

                                                switch (testing)
                                                {
                                                    case 1:
                                                        double selectpaper1 = 0;
                                                        double papersize = 0;
                                                        double checkValid;
                                                        bool loop = false;
                                                        while (!loop)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("|            Paper Size your choice          |");
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("+ 1.Papersize: A4                            +");
                                                            Console.WriteLine("+ 2.Papersize: A3                            +");
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("Please choose one");
                                                            int action;
                                                            try
                                                            {
                                                                action = int.Parse(Console.ReadLine());
                                                                switch (action)
                                                                {
                                                                    case 1:
                                                                        if (coppyList[update].Feature == "Single")
                                                                        {
                                                                            loop = true;
                                                                            papersize = 100;
                                                                        }
                                                                        if (coppyList[update].Feature == "Multifunction")
                                                                        {
                                                                            loop = true;
                                                                            papersize = 97;
                                                                        }
                                                                        break;
                                                                    case 2:

                                                                        if (coppyList[update].Feature == "Single")
                                                                        {
                                                                            loop = true;
                                                                            papersize = 200;
                                                                        }
                                                                        if (coppyList[update].Feature == "Multifunction")
                                                                        {
                                                                            loop = true;
                                                                            papersize = 195;
                                                                        }
                                                                        break;
                                                                }
                                                            }
                                                            catch (System.Exception e)
                                                            {
                                                                invalidNotification();
                                                            }
                                                        }
                                                        checkValid = 0;
                                                        while (loop)
                                                        {  
                                                                Console.Clear();
                                                                Console.WriteLine("+--------------------------------------------+");
                                                                Console.WriteLine("|           Paper you want to scan          |");
                                                                Console.WriteLine("+--------------------------------------------+");
                                                                Console.WriteLine("+ Input the paper:                           +");
                                                                try
                                                                {
                                                                    checkValid = double.Parse(Console.ReadLine());

                                                                    selectpaper1 = checkValid;
                                                                    if (checkValid > coppyList[update].Paper)
                                                                    {
                                                                        Console.WriteLine("Error: The number of sheets of paper you want to copy is greater than the number of sheets of paper available.");
                                                                        Console.WriteLine("Input Again");
                                                                    }
                                                                if(checkValid < coppyList[update].Paper)
                                                                {
                                                                    loop = false;
                                                                }

                                                                }
                                                                catch (System.Exception e)
                                                                {
                                                                    invalidNotification();
                                                                }
                                                            
                                                        }
                                                        Console.WriteLine("");
                                                        Console.WriteLine("");
                                                        Console.WriteLine("Time the machine completes copying documents with speed is 10-20ppm  and 300PDI: ");
                                                        Console.WriteLine(changeToMinute(Math.Round(coppyList[update].Scan(selectpaper1, papersize))));
                                                        Console.ReadLine();
                                                        break;
                                                    case 2:
                                                        double selectpaper2 = 0;
                                                        bool loop1 = true; // Khởi tạo loop1 là true để bắt đầu vòng lặp
                                                        checkValid = 0;
                                                        while (loop1)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("|           Paper your want to copy          |");
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("+ Input the paper:                           +");
                                                            try
                                                            {
                                                                checkValid = double.Parse(Console.ReadLine());

                                                                selectpaper2 = checkValid;
                                                                if (checkValid > coppyList[update].Paper)
                                                                {
                                                                    Console.WriteLine("Error: The number of sheets of paper you want to copy is greater than the number of sheets of paper available.");
                                                                    Console.WriteLine("Input Again");
                                                                }
                                                                else
                                                                {
                                                                    loop1 = false; // Exit if false paper
                                                                }
                                                            }
                                                            catch (System.Exception e)
                                                            {
                                                                invalidNotification();
                                                            }
                                                        }
                                                        Console.WriteLine("");
                                                        Console.WriteLine("");
                                                        Console.WriteLine("Time the machine completes copying documents with speed is 20ppm: ");
                                                        Console.WriteLine(changeToMinute(Math.Round(coppyList[update].Copy(selectpaper2))));
                                                        Console.ReadLine();
                                                        break;
                                                    case 3:
                                                        double faxNumber = 0;
                                                        bool isValid = false; 
                                                     
                                                        if (coppyList[update].Feature == "Single")
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("This machine does not support fax function");
                                                            Console.ReadLine();
                                                        }
                                                        if (coppyList[update].Feature == "Multifunction")
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("The fax number you enter to send the document");
                                                            try
                                                            {
                                                                faxNumber = double.Parse(Console.ReadLine());
                                                            } catch(System.Exception e)
                                                            {
                                                                Console.WriteLine("Fax numbers cannot be text");
                                                            }
                                                            Console.Clear();
                                                            Console.WriteLine("Fax Number: " + coppyList[update].Fax(faxNumber));
                                                            Console.ReadLine();
                                                        }
                                                        
                                                     
                                                        break;
                                                    case 4:
                                                        CopyTest = true;
                                                        break;
                                                    default:
                                                        invalidNotification();
                                                        break;
                                                }
                                            }
                                            catch (System.Exception e)
                                            {
                                                invalidNotification();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine("+------------------------------------------------------+");
                                        Console.WriteLine("|  Your product must have full information to testing  |");
                                        Console.WriteLine("+------------------------------------------------------+");
                                        Console.ReadLine();
                                    }
                                }
                                if (PrintChoice)
                                {
                                    if (!string.IsNullOrEmpty(printerList[update].Paper.ToString()))
                                    {
                                        bool PrintTest = false;
                                        while (!PrintTest)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("+--------------------------------------------+");
                                            Console.WriteLine("|                    ACTION                  |");
                                            Console.WriteLine("+--------------------------------------------+");
                                            Console.WriteLine("| 1. Time to scan documents                  |");
                                            Console.WriteLine("| 2. Document copy time.                     |");       
                                            Console.WriteLine("| 3. Back                                    |");
                                            Console.WriteLine("+--------------------------------------------+");
                                            Console.WriteLine("");
                                            Console.WriteLine("Please choose one");
                                            int testing;
                                            try
                                            {
                                                testing = int.Parse(Console.ReadLine());

                                                switch (testing)
                                                {
                                                    case 1:
                                                        double selectpaper1 = 0;
                                                        double papersize1 = 0;
                                                        double checkValid;
                                                        bool loop = false;
                                                        while (!loop)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("|            Paper Size your choice          |");
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("+ 1.Papersize: A4                            +");
                                                            Console.WriteLine("+ 2.Papersize: A3                            +");
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("Please choose one");
                                                            int action;
                                                            try
                                                            {
                                                                action = int.Parse(Console.ReadLine());
                                                                switch (action)
                                                                {
                                                                    case 1:
                                                                        if (printerList[update].Feature == "Single")
                                                                        {
                                                                            loop = true;
                                                                            papersize1 = 97;
                                                                        }
                                                                        else if (printerList[update].Feature == "Multifunction")
                                                                        {
                                                                            loop = true;
                                                                            papersize1 = 96;
                                                                        }
                                                                        break;
                                                                    case 2:
                                                                        if (printerList[update].Feature == "Single")
                                                                        {
                                                                            loop = true;
                                                                            papersize1 = 195;
                                                                        }
                                                                        else if (printerList[update].Feature == "Multifunction")
                                                                        {
                                                                            loop = true;
                                                                            papersize1 = 192;
                                                                        }
                                                                        break;
                                                                }
                                                            }
                                                            catch (System.Exception e)
                                                            {
                                                                invalidNotification();
                                                            }
                                                        }
                                                        checkValid = 0;
                                                        while (loop)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("|           Paper your want to scan          |");
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("+ Input the paper:                           +");
                                                            try
                                                            {
                                                                checkValid = double.Parse(Console.ReadLine());

                                                                selectpaper1 = checkValid;
                                                                if (checkValid > printerList[update].Paper)
                                                                {
                                                                    Console.WriteLine("Error: The number of sheets of paper you want to scan is greater than the number of sheets of paper available.");
                                                                    Console.WriteLine("Input Again");
                                                                }
                                                                else
                                                                {
                                                                    loop = false;
                                                                }
                                                            }
                                                            catch (System.Exception e)
                                                            {
                                                                invalidNotification();
                                                            }
                                                        }
                                                        Console.WriteLine("");
                                                        Console.WriteLine("");
                                                        Console.WriteLine("Time the machine completes scanning documents with speed is 20-30ppm and 300PDI: ");
                                                        Console.WriteLine(changeToMinute(Math.Round(printerList[update].ScanDocument(selectpaper1, papersize1))));
                                                        Console.ReadLine();
                                                        break;

                                                    case 2:
                                                        double selectpaper2 = 0;
                                                        double papersize2 = 0;
                                                        checkValid = 0;
                                                        bool loop1 = false;
                                                        while (!loop1)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("|            Paper Size your choice          |");
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("+ 1.Papersize: A4                            +");
                                                            Console.WriteLine("+ 2.Papersize: A3                            +");
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("Please choose one");
                                                            int action;
                                                            try
                                                            {
                                                                action = int.Parse(Console.ReadLine());
                                                                switch (action)
                                                                {
                                                                    case 1:
                                                                        if (printerList[update].Feature == "Single")
                                                                        {
                                                                            loop1 = true;
                                                                            papersize2 = 97;
                                                                        }
                                                                        else if (printerList[update].Feature == "Multifunction")
                                                                        {
                                                                            loop1 = true;
                                                                            papersize2 = 96;
                                                                        }
                                                                        break;
                                                                    case 2:
                                                                        if (printerList[update].Feature == "Single")
                                                                        {
                                                                            loop1 = true;
                                                                            papersize2 = 195;
                                                                        }
                                                                        else if (printerList[update].Feature == "Multifunction")
                                                                        {
                                                                            loop1 = true;
                                                                            papersize2 = 192;
                                                                        }
                                                                        break;
                                                                }
                                                            }
                                                            catch (System.Exception e)
                                                            {
                                                                invalidNotification();
                                                            }
                                                        }
                                                        checkValid = 0;
                                                        while (loop1)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("|          Paper your want to print          |");
                                                            Console.WriteLine("+--------------------------------------------+");
                                                            Console.WriteLine("+ Input the paper:                           +");
                                                            try
                                                            {
                                                                checkValid = double.Parse(Console.ReadLine());

                                                                selectpaper2 = checkValid;
                                                                if (checkValid > printerList[update].Paper)
                                                                {
                                                                    Console.WriteLine("Error: The number of sheets of paper you want to print is greater than the number of sheets of paper available.");
                                                                    Console.WriteLine("Input Again");
                                                                }
                                                                else
                                                                {
                                                                    loop1 = false;
                                                                }
                                                            }
                                                            catch (System.Exception e)
                                                            {
                                                                invalidNotification();
                                                            }
                                                        }
                                                        Console.WriteLine("");
                                                        Console.WriteLine("");
                                                        Console.WriteLine("Time the machine completes printing documents with speed is 20-30ppm and 300PDI: ");
                                                        Console.WriteLine(changeToMinute(Math.Round(printerList[update].SidedPrint(selectpaper2, papersize2))));
                                                        Console.ReadLine();
                                                        break;

                                                    case 3:
                                                        PrintTest = true;
                                                        break;
                                                    default:
                                                        invalidNotification();
                                                        break;
                                                }
                                            }
                                            catch (System.Exception e)
                                            {
                                                invalidNotification();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine("+------------------------------------------------------+");
                                        Console.WriteLine("|  Your product must have full information to test  |");
                                        Console.WriteLine("+------------------------------------------------------+");
                                        Console.ReadLine();
                                    }
                                }
             
                            }
                            catch (System.Exception e)
                            {
                                invalidNotification();
                            }
                            break;                  
                        case 6:
                            exit = true;
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("+--------------------------------------------+");
                            Console.WriteLine("|                SEE YOU AGAIN               |");
                            Console.WriteLine("+--------------------------------------------+");
                            break;
                        default:
                            invalidNotification();
                            break;
                    }
                }
                catch (System.Exception e)
                {
                    invalidNotification();
                }
            }
            void productList()
            {
                if (coppyList.Count == 0 && printerList.Count == 0)
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("+------------------------------------------------------+");
                    Console.WriteLine("|      You must have at least one product to show      |");
                    Console.WriteLine("+------------------------------------------------------+");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("------------------- Product List--------------------");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("+----------------------------------------------------------------------+");
                    Console.WriteLine("|  Num  |  Product  |         Fearture       |    Paper    |   Color  |+");
                    Console.WriteLine("+----------------------------------------------------------------------+");
                    int numTest = 1;
                    for (int i = 0; i < coppyList.Count; i++)
                    {
                        if (!string.IsNullOrEmpty(coppyList[i].Name))
                        {
                            Console.WriteLine("|   " + (numTest) + "   |  " + coppyList[i].Name + "     |      " + coppyList[i].Feature +
                            "     |    " + coppyList[i].Paper + whiteSpace(coppyList[i].Paper.ToString()) + "    |   " + coppyList[i].Color  + "  | ");
                            Console.WriteLine("+----------------------------------------------------------------------+");
                            numTest++;
                        }
                    }
                    for (int i = 0; i < printerList.Count; i++)
                    {
                        if (!string.IsNullOrEmpty(printerList[i].Name))
                        {
                            Console.WriteLine("|   " + (numTest) + "   |   " + printerList[i].Name + "    |         " + printerList[i].Feature +
                            "       |    " + printerList[i].Paper + whiteSpace(printerList[i].Paper.ToString()) + "    |  " + printerList[i].Color + whiteSpace(printerList[i].Color) + "  |  ");
                            Console.WriteLine("+----------------------------------------------------------------------+");
                            numTest++;
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
            }
            void invalidNotification()
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("+--------------------------------------------+");
                Console.WriteLine("|               Choice invalid!              |");
                Console.WriteLine("+--------------------------------------------+");
                Console.ReadLine();
            }
            void updateNotification()
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("+--------------------------------------------+");
                Console.WriteLine("|               Update successfully!              |");
                Console.WriteLine("+--------------------------------------------+");
                Console.ReadLine();
            }
            void deleteNotification()
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("+--------------------------------------------+");
                Console.WriteLine("|              Delete successfully                |");
                Console.WriteLine("+--------------------------------------------+");
                Console.ReadLine();
            }
            void createNotification()
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("+--------------------------------------------+");
                Console.WriteLine("|               Create successfully            |");
                Console.WriteLine("+--------------------------------------------+");
                Console.ReadLine();
            }
            string whiteSpace(string value)
            {
                string space = "";
                if (value == null)
                {
                    space = space + "         ";
                }
                else
                {
                    return space;
                }
                return space;
            }
            string changeToMinute(double value)
            {
                double minute = value / 60;
                double second = value % 60;
                return Math.Round(minute) + " minute + " + Math.Round(second) + " second";
            }
        }
    }
}
