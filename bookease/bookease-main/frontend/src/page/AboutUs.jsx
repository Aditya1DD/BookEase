import {
  MDBCard,
  MDBCardBody,
  MDBCardTitle,
  MDBCardText,
  MDBCardImage,
  MDBBtn
} from 'mdb-react-ui-kit';
import img1 from "../images/60111.jpg";
const AboutUs = () => {
  return (
    <div className="text-color ms-5 me-5 mr-5 mt-3" style={{ fontSize: '20px' }}>
    <b>
    At BookEase, we're passionate about simplifying hotel management and enhancing guest experiences. With a team of dedicated developers and hospitality experts, we've created a modern, user-friendly web-based application that empowers hotel managers to efficiently handle all aspects of their operations.

Our mission is to provide innovative solutions that enable hotels to thrive in today's competitive market. With BookEase, we aim to revolutionize the way hotels manage bookings, allocate rooms, and deliver services, ultimately improving efficiency and guest satisfaction.

Backed by cutting-edge technologies such as React, MySQL, and Spring Boot, BookEase offers a flexible and scalable platform tailored to meet the unique needs of each hotel. Whether you're a boutique hotel or a large chain, BookEase is designed to adapt and grow with your business.
      <br />
      <br />
     

We're passionate about simplifying hotel management and enhancing guest experiences. With a team of dedicated developers and hospitality experts, we've created a modern, user-friendly web-based application that empowers hotel managers to efficiently handle all aspects of their operations.

Our mission is to provide innovative solutions that enable hotels to thrive in today's competitive market. With BookEase, we aim to revolutionize the way hotels manage bookings, allocate rooms, and deliver services, ultimately improving efficiency and guest satisfaction.

Backed by cutting-edge technologies such as React, MySQL, and Spring Boot, BookEase offers a flexible and scalable platform tailored to meet the unique needs of each hotel. Whether you're a boutique hotel or a large chain, BookEase is designed to adapt and grow with your business.

At BookEase, we're committed to delivering exceptional value to our clients. Our team is dedicated to providing ongoing support and updates to ensure that your experience with BookEase is seamless and successful.
    </b>
   <br />
   <br />
   <br />
  
     {/* ========== user tiles  ============== */}
     <div id="blogs">
              <div className="container  justify-content-center" >
                <div className="row">
                    <div className="col heading">
                      <h3 id="project-cont">Project Contributors</h3>
                    </div>
                </div>
               
                <div className="row" >
                    {/* 1st  */}
                  <div className="col-md-2 blog_cols">
                    <div className="img">
                      <img src="../images/60111.jpg" alt="" width="100%" />
                    </div>
                    <p className="lead">Linked In</p>
                    <h5 className="news_heading">
                      <a href="https://www.linkedin.com/feed/">
                     Abhishek Kadam
                      </a>
                    </h5>                  
                  </div>
                    {/* 2nd  */}
                  <div className="col-md-2 blog_cols">
                    <div className="img">
                      <img src="{img1}" alt="" width="100%" />
                    </div>
                    <p className="lead">Linked In</p>
                    <h5 className="news_heading">
                      <a href="https://www.linkedin.com/feed/">
                      Saurabh Wanjari
                      </a>
                    </h5>                  
                  </div>
                    {/* 3rd  */}
                  <div className="col-md-2 blog_cols">
                    <div className="img">
                      <img src="/img/home/60111.jpg" alt="" width="100%" />
                    </div>
                    <p className="lead">Linked In</p>
                    <h5 className="news_heading">
                      <a href="https://www.linkedin.com/feed/">
                     Aditya Dhole
                      </a>
                    </h5>                  
                  </div>
                    {/* 4th  */}
                  <div className="col-md-2 blog_cols">
                    <div className="img">
                      <img src="/img/home/60111.jpg" alt="" width="100%" />
                    </div>
                    <p className="lead">Linked In</p>
                    <h5 className="news_heading">
                      <a href="https://www.linkedin.com/feed/">
                   Ritusha Salunkhe
                      </a>
                    </h5>                  
                  </div>
                    {/* 5th  */}
                  <div className="col-md-2 blog_cols">
                    <div className="img">
                      <img src="/img/home/60111.jpg" alt="" width="100%" />
                    </div>
                    <p className="lead">Linked In</p>
                    <h5 className="news_heading">
                      <a href="https://www.linkedin.com/feed/">
                    Abhilash Khedvan
                      </a>
                    </h5>                  
                  </div>
                </div>
              </div>
            </div>

    
  </div>
  
    
  );
};

export default AboutUs;
