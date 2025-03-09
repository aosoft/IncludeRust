#[unsafe(no_mangle)]
pub unsafe extern "C" fn add2(left: i32, right: i32) -> i32 {
    let r = left + right;
    println!("{}", r);
    r
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn it_works() {
        unsafe {
            let result = add2(2, 2);
            assert_eq!(result, 4);
        }
    }
}
