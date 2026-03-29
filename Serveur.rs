use std::net::TcpListener;
use std::net::TcpStream;
use std::io::Write;
use std::io::Read;
use std::thread;
use std::sync::mpsc;

fn main() {

    let (tx, rx) = mpsc::channel();

    thread::spawn(move || {
        let listener = TcpListener::bind("127.0.0.1:4444").unwrap();
    
        for stream in listener.incoming() {
            let mut stream = stream.expect("Error: No connection established...");
            println!("Connection established!");
            
            let mut buffer = Vec::new();
            let _message = stream.read_to_end(&mut buffer);
            tx.send(buffer).unwrap();
            println!("Message sent to other client :{:?}",String::from_utf8(buffer).unwrap());
        }
    });

    match TcpStream::connect("127.0.0.1:4444"){
        Ok(mut stream)=>{
            println!("Connected to server!");
                
            let message_to_send = rx.recv().unwrap();
            let u8_mts = message_to_send.as_bytes();

            println!("{:?}", message_to_send);

            stream.write_all(&message_to_send).unwrap();
            stream.flush().unwrap();
   
        },
        Err(_e) =>{
            println!("Error: Couldn't connect to server...");
        }
    }
    handle.join().unwrap();
}