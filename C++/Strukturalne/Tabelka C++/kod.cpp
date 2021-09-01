#include <iostream>

int main()
{
	/*int r = 0, c = 0;
	int y;

	std::cout << "<table>" << std::endl;

	for (r; r < 33; r++)
	{
		std::cout << "    <tr>" << std::endl;

		for (c; c < 33; c++)
		{

			std::cout << "        <td>";

			if (r + c < 32 || r < c)
			{
				y = (-4 * r) + (131 * r) + 1 + c;
				std::cout << y;
			}
			else if (r < c || r + c > 32)
			{
				y = (-4 * r) + (131 * r) + 1 + c;
				std::cout << y;
			}
			else if (r + c > 32 || r > c)
			{
				y = (-4 * r) + (131 * r) + 1 + c;
				std::cout << y;
			}
			else
			{
				y = (-4 * r) + (131 * r) + 1 + c;
				std::cout << y;
			}

			std::cout << "</td>" << std::endl;
		}

		std::cout << "    </tr>" << std::endl;
	}

	std::cout << "<table>" << std::endl;
	return 0;*/



	int r = 0, c = 0, y = (-4 * r) + (131 * r) + 1 + c;
	std::cout << "<table>" << std::endl;

    for (int i; i < 33; i++)
    {
    	std::cout << "        <tr>" << std::endl;

		for (int t = 0; t < 33; t++)
		{
				std::cout << "            <td>";
                std::cout << y;
                y++;
			    std::cout << "</td>" << std::endl;
		}

    	std::cout << "        </tr>" << std::endl;
    }

	std::cout << "    </table>" << std::endl;

	return 0;
}
