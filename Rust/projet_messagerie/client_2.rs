use std::net::TcpStream;
use std::io::Write;
use std::io;

fn main(){
    loop {
        match TcpStream::connect("127.0.0.1:4444"){
            Ok(mut stream)=>{
                println!("Connected to server! Please type your message:");
                let mut input = String::new();
                match io::stdin().read_line(&mut input) {
                    Ok(_n) => {
                        let u8_input = input.as_bytes();
                        stream.write_all(u8_input).unwrap();
                        stream.flush().unwrap();
                    }   
                    Err(error) =>{
                        println!("error: {error}");
                    }          
            }
            },
            Err(_e) =>{
                println!("Error: Couldn't connect to server...");
            }
        }       
    }
}