#include <iostream>
#include <string>
using namespace std;

template <typename T>
class MyQueue
{
private:
	struct Node
	{
		T value;
		Node *next;
		Node(T value, Node *next)
		{
			this->value = value;
			this->next = next;
		}
	};
	Node* head;
	Node* tail;
public:
	MyQueue()
	{
		head = NULL;
		tail = NULL;
	}
	~MyQueue()
	{
		while (!empty())
		{
			pop();
		}
	}
	void pop()
	{
		if (head == NULL)
			return;
		Node* p = head;
		head = head->next;
		if (!head)
			tail = NULL;
		delete p;
	}
	T front()
	{
		return head->value;
	}
	bool empty()
	{
		return !head;
	}
	void push(T val)
	{
		Node* node = new Node(val, NULL);
		if (tail == NULL)
			head = node;
		else
			tail->next = node;
		tail = node;
	}

};


class Graph
{
private:
	int numOfVertex;
	bool** adjMatrix;
public:
	Graph(int numOfVertex)
	{
		this->numOfVertex = numOfVertex;
		adjMatrix = new bool*[numOfVertex];
		for (int i = 0; i < numOfVertex; ++i)
		{
			adjMatrix[i] = new bool[numOfVertex];
			for (int j = 0; j < numOfVertex; ++j)
				adjMatrix[i][j] = false;
		}
	}
	void addEdge(short x, short y)
	{
		adjMatrix[x][y] = true;
		adjMatrix[y][x] = true;
	}
	void printMatrix()
	{
		for (int i = 0; i < numOfVertex; ++i)
		{
			for (int j = 0; j < numOfVertex; ++j)
				cout << adjMatrix[i][j] << " ";
			cout << endl;
		}
	}
	int findBSL(int startPoint, int endPoint)
	{
		//int* counter = new int[numOfVertex];
		short* counter = new short[numOfVertex];
		MyQueue<short> q;
		for (int i = 0; i < numOfVertex; ++i)
			counter[i] = 0;

		q.push(startPoint);

		while (!q.empty())
		{
			int v = q.front();
			q.pop();
			if (v == endPoint)
			{
				int temp = counter[v];
				delete[] counter;
				return temp;
			}
			for (int i = 0; i < numOfVertex; ++i)
			{
				if (adjMatrix[v][i] == false || counter[i] != 0)
					continue;
				q.push(i);
				counter[i] = counter[v] + 1;
			}
		}
		delete[] counter;
		return -1;

	}
};


int main()
{
	int n, m;
	cin >> n >> m;
	Graph graph(n);
	for (int i = 0; i < m; ++i)
	{
		int u, v;
		cin >> u >> v;
		graph.addEdge(u, v);
	}

	int p1, p2;
	cin >> p1 >> p2;

	int numOfPoints;
	cin >> numOfPoints;
	int point;

	int lastUsed = 0;
	string result;
	for (int i = 0; i < numOfPoints; i++)
	{
		cin >> point;
		if (graph.findBSL(p1, point) < graph.findBSL(p2, point))
		{
			result += "1 ";
			p1 = point;
			lastUsed = 1;
		}
		else if (graph.findBSL(p2, point) < graph.findBSL(p1, point))
		{
			result += "2 ";
			p2 = point;
			lastUsed = 2;
		}
		else if (((graph.findBSL(p1, point)) == -1) && (graph.findBSL(p2, point)) == -1)
		{
			cout << "Brak po³¹czenia z wierzcho³kiem " << point;
			return 0;
		}
		else
		{
			if (lastUsed == 1)
			{
				result += "2 ";
				p2 = point;
				lastUsed = 2;
			}
			else
			{
				result+= "1 ";
				p1 = point;
				lastUsed = 1;
			}
		}
	}
	cout << result;
}