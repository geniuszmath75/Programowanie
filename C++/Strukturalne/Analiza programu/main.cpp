#include <iostream>   
#define WYPISZ(x) std::cout<<#x<<"="<<x<<"\n";
#define _ZNAK_                            
int dz=10;                                
                                           
int& fun(int& a,int& b) { WYPISZ(__LINE__);// WYPISZ(fun(i,j));   fun(i,j)=7;      
  if(a<b) return b;                       
  else return a;
}                                
int fun(const int* a,const int* b=&dz){  WYPISZ(__LINE__);// WYPISZ(fun(&j);, WYPISZ((fun(&c,&d));    
  return *a+*b;                           
}                                         
const int& fun(const int& a,const int& b){ WYPISZ(__LINE__);// WYPISZ(fun(c,d));
  if(a<b) return b;                       
  else return a;                          
}                                          
int fun(int* t, int n){  WYPISZ(__LINE__);// WYPISZ(fun(tab,5));                 
  return (n>0 ? t[0] + fun(t+1,n-1) : 0); 
}                                         
int fun(int n,int t[]){   WYPISZ(__LINE__);// WYPISZ(fun(2,tab));                 
  int k=t[0];                             
  for(int i=1;i<n;++i) k=fun(k,t[i]);      
  return k;                                
}                                          
double& fun(double& a,double& b){   WYPISZ(__LINE__);// WYPISZ(fun(p,e));      
  if(a>b){                              
    double c=b;                           
    b=a; a=c;                             
  }                                       
  return a;                                
}                                        
                                         
#if defined(_ZNAK_)                        
  char* fun(int n,char* t[]){   WYPISZ(__LINE__);// WYPISZ(fun(argc-1,argv+1));        
    char c=t[0][0];                       
    if(n>1){                              
      char* p=fun(n-1,t+1);               
      char d=*p;                         
      return (c>d ? t[0] : p);             
    }else return t[0];                    
  }                                        
#endif                                     

int main(int argc, char* argv[]){        
  using namespace std;                    
  double e=2.718, p=3.14;              
  int i=5,j=11;                         
  const int c=13,d=12;
  WYPISZ(fun(&j));
  WYPISZ(fun(p,e));                      
  WYPISZ(p);                              
  WYPISZ(e);                              
  WYPISZ(fun(i,j));                        
  WYPISZ(fun(&c,&d));                     
  WYPISZ(fun(c,d));                       
  fun(i,j)=7;                            
  WYPISZ(i);                              
  WYPISZ(j);                             
  WYPISZ(c);                               
  WYPISZ(d);                               
  int tab[]={7,3,11,5,19};                
  WYPISZ(fun(tab,5));                      
  WYPISZ(fun(2,tab));                     
  if(argc>1) WYPISZ(fun(argc-1,argv+1));   
}                                          
