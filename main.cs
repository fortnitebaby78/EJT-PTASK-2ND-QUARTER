using System;

class HelloWorld {
	static void Main(string[] args) {
		// Declare variables for storing student information
		string fname, midname, lname, id;   // First, Middle, Last name, and Student ID
		int grade;                          // Grade level (11 or 12)
		double tuition = 40000;             // â‚±40,000 fixed tuition fee
		string strand, select;              // Student's chosen strand and menu selection
		double deposit, balance, monthly;   // Payment details (deposit, balance, monthly installment)


		// Student Information Input
		Console.Write("Enter First Name: ");
		fname = Console.ReadLine();   // Get first name

		Console.Write("Enter Middle Name: ");
		midname = Console.ReadLine(); // Get middle name

		Console.Write("Enter Last Name: ");
		lname = Console.ReadLine();   // Get last name

		Console.Write("Enter Student ID: ");
		id = Console.ReadLine();      // Get student ID


		// Grade Level Input. Loop until user enters a valid grade (only 11 or 12 can be entered)
		while (true) {
			Console.Write("Enter Grade Level (11 or 12): ");
			try {
				// Convert input to integer
				grade = Convert.ToInt32(Console.ReadLine());

				// Accepts only 11 or 12
				if (grade == 11 || grade == 12) break;
				else Console.WriteLine("Invalid Input. Enter 11 or 12 only\n");
			}
			catch {
				// If input is not a number, like letters or etc, it will show invalid input and loop again
				Console.WriteLine("Invalid Input. Enter 11 or 12 only\n");
			}
		}

		// Tuition Fee Payment
		Console.WriteLine($"\nTuition Fee: â‚±{tuition}");

		// It will loop until valid deposit is entered (0 to 40,000 only)
		while (true) {
			Console.Write("Enter deposit amount: â‚±");
			try {
				deposit = Convert.ToDouble(Console.ReadLine());

				// Checks if input is from 0 to 40,000
				if (deposit >= 0 && deposit <= 40000) break;
				else Console.WriteLine("Invalid amount. Enter between 0 and 40000 only.\n"); // If input is not from 0 to 40,000, it will print invalid amount
			}
			catch {
				// If input is not a number, it will print invalid amount
				Console.WriteLine("Invalid input. Numbers only\n");
			}
		}

		// Calculates the balance and monthly payment
		balance = tuition - deposit;   // Remaining balance after deposit
		monthly = balance / 10;        // Divide it into 10 for the monthly payments

		// Strand Selection, It will loop until a valid strand is selected
		while (true) {
			Console.Write("\nEnter strand (STEM / ABM / HUMSS / ICT / DIGITAL ARTS / TOURISM OPERATIONS): ");
			strand = Console.ReadLine().ToUpper(); // Convert to uppercase for easier comparison

			// Accepts only the strands listed here
			if (strand == "STEM" || strand == "ABM" || strand == "HUMSS" ||
			        strand == "ICT" || strand == "DIGITAL ARTS" || strand == "TOURISM OPERATIONS") break;
			else {
				Console.WriteLine("Invalid strand. Please enter one of the listed options.");
			}
		}

		// Main Menu Loop. User chooses whether to view subjects, balance, or exit
		while (true) {
			Console.Write("\nType SUBJECTS or BALANCE (EXIT to quit): \n\n");
			select = Console.ReadLine().ToUpper();

			// If user types "SUBJECTS", it will show the students information, and subjects
			if (select == "SUBJECTS") {
				Console.WriteLine("\nStudent Information:");
				Console.WriteLine($"Student Name: {fname} {midname} {lname}");
				Console.WriteLine($"Student ID: {id}");
				Console.WriteLine($"Grade Level: {grade}");
				Console.WriteLine($"Strand: {strand}");

				Console.WriteLine("\nSubjects:");

				// If the student is in Grade 11
				if (grade == 11) {
					// STEM Strand subjects for Grade 11
					if (strand == "STEM") {
						Console.WriteLine("Oral Communication\nGeneral Mathematics\nEarth and Life Science\nPre-Calculus\n21st Century Literature\nKomunikasyon at Pananaliksik sa Wika at Kulturang Pilipino\nPhysical Education and Health 1\nIntroduction to Philosophy of the Human Person");
					}
					// ABM Strand subjects for Grade 11
					else if (strand == "ABM") {
						Console.WriteLine("Oral Communication\nGeneral Mathematics\nFundamentals of Accountancy, Business and Management 1\nBusiness Mathematics\n21st Century Literature\nKomunikasyon at Pananaliksik sa Wika at Kulturang Pilipino\nPhysical Education and Health 1\nEarth and Life Science");
					}
					// HUMSS Strand subjects for Grade 11
					else if (strand == "HUMSS") {
						Console.WriteLine("Oral Communication\nGeneral Mathematics\nIntroduction to World Religions and Belief Systems\nCreative Writing\n21st Century Literature\nKomunikasyon at Pananaliksik sa Wika at Kulturang Pilipino\nPhysical Education and Health 1\nEarth and Life Science");
					}
					// ICT Strand subjects for Grade 11
					else if (strand == "ICT") {
						Console.WriteLine("Oral Communication\nGeneral Mathematics\nEmpowerment Technologies\nComputer Programming 1 (Java Basics)\n21st Century Literature\nKomunikasyon at Pananaliksik sa Wika at Kulturang Pilipino\nPhysical Education and Health 1\nEarth and Life Science");
					}
					// Digital Arts Strand subjects for Grade 11
					else if (strand == "DIGITAL ARTS") {
						Console.WriteLine("Oral Communication\nGeneral Mathematics\nIntroduction to Multimedia Arts\nDigital Illustration\n21st Century Literature\nKomunikasyon at Pananaliksik sa Wika at Kulturang Pilipino\nPhysical Education and Health 1\nEarth and Life Science");
					}
					// Tourism Operations Strand subjects for Grade 11
					else if (strand == "TOURISM OPERATIONS") {
						Console.WriteLine("Oral Communication\nGeneral Mathematics\nTourism Promotion Services\nLocal Tourism & Heritage Studies\n21st Century Literature\nKomunikasyon at Pananaliksik sa Wika at Kulturang Pilipino\nPhysical Education and Health 1\nEarth and Life Science");
					}
				}
				// If the student is in Grade 12
				else if (grade == 12) {
					// STEM Strand subjects for Grade 12
					if (strand == "STEM") {
						Console.WriteLine("Practical Research 2\nGeneral Physics 2\nGeneral Biology 2\nBasic Calculus\nPhysical Science\nFilipino sa Piling Larang (Academic)\nPhysical Education and Health 3\nPagbasa at Pagsusuri ng Iba't Ibang Teksto Tungo sa Pananaliksik");
					}
					// ABM Strand subjects for Grade 12
					else if (strand == "ABM") {
						Console.WriteLine("Practical Research 2\nFundamentals of Accountancy, Business and Management 2\nBusiness Finance\nApplied Economics\nPhysical Science\nFilipino sa Piling Larang (Academic)\nPhysical Education and Health 3\nPagbasa at Pagsusuri ng Iba't Ibang Teksto Tungo sa Pananaliksik");
					}
					// HUMSS Strand subjects for Grade 12
					else if (strand == "HUMSS") {
						Console.WriteLine("Practical Research 2\nDisciplines and Ideas in Social Sciences\nCommunity Engagement, Solidarity, and Citizenship\nCreative Nonfiction\nPhysical Science\nFilipino sa Piling Larang (Akademik)\nPhysical Education and Health 3\nPagbasa at Pagsusuri ng Iba't Ibang Teksto Tungo sa Pananaliksik");
					}
					// ICT Strand subjects for Grade 12
					else if (strand == "ICT") {
						Console.WriteLine("Practical Research 2\nComputer/Web Programming 3\nSystems Analysis and Design\nDatabase Management Systems\nPhysical Science\nFilipino sa Piling Larang (Tech-Voc)\nPhysical Education and Health 3\nPagbasa at Pagsusuri ng Iba't Ibang Teksto Tungo sa Pananaliksik");
					}
					// Digital Arts Strand subjects for Grade 12
					else if (strand == "DIGITAL ARTS") {
						Console.WriteLine("Practical Research 2\nAnimation 2D/3D\nDigital Photography and Videography\nGraphic Design for Print and Web\nPhysical Science\nFilipino sa Piling Larang (Arts)\nPhysical Education and Health 3\nPagbasa at Pagsusuri ng Iba't Ibang Teksto Tungo sa Pananaliksik");
					}
					// Tourism Operations Strand subjects for Grade 12
					else if (strand == "TOURISM OPERATIONS") {
						Console.WriteLine("Practical Research 2\nTourism Planning and Development\nHospitality Management\nFood and Beverage Services\nPhysical Science\nFilipino sa Piling Larang (Tech-Voc)\nPhysical Education and Health 3\nPagbasa at Pagsusuri ng Iba't Ibang Teksto Tungo sa Pananaliksik");
					}
				}
            }
				// If the user types "BALANCE", it will show the students information, and the payment details
				else if (select == "BALANCE") {
					Console.WriteLine("\nStudent Information:");
					Console.WriteLine($"Student Name: {fname} {midname} {lname}");
					Console.WriteLine($"Student ID: {id}");
					Console.WriteLine($"Grade Level: {grade}");
					Console.WriteLine($"Strand: {strand}");

					Console.WriteLine("\nBalance:");
					Console.WriteLine($"Tuition Fee: â‚±{tuition}");
					Console.WriteLine($"Deposit: â‚±{deposit}");
					Console.WriteLine($"Remaining Balance: â‚±{balance}");
					Console.WriteLine($"Monthly Payment (10 months): â‚±{monthly}");
				}

				// If the user types "EXIT", it will quit the program
				else if (select == "EXIT") {
					Console.WriteLine("\nGoodbye");
					break;
				}

				// If the user types something invalid, it will show invalid choice message
				else {
					Console.WriteLine("\nInvalid choice.");
				}
			}
		}
	}